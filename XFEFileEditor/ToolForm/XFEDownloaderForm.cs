using System.Diagnostics;
using XFEFileEditor.Profiles;
using XFE各类拓展.NetCore.FileExtension;
using XFE各类拓展.NetCore.StringExtension;
using XFE各类拓展.NetCore.WebExtension;

namespace XFEFileEditor
{
    public partial class XFEDownloaderForm : Form
    {
        public bool IsDownloadPausedOrCompleted { get; set; } = true;
        public static XFEDownloaderForm? Current { get; private set; }
        public XFEDownloader? CurrentDownloader { get; set; }
        public XFEDownloaderForm()
        {
            InitializeComponent();
            Current = this;
            threadCountTrackBar.Value = ToolFormProfile.DownloadThreadCount;
            fileDownloadPathLabel.Text = $"根目录：{ToolFormProfile.XFEDownloaderRootPath}";
        }

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            if (IsDownloadPausedOrCompleted)
            {
                downloadButton.Text = "暂停/取消下载";
                IsDownloadPausedOrCompleted = false;
            }
            else
            {
                downloadButton.Text = "开始下载";
                IsDownloadPausedOrCompleted = true;
                if (CurrentDownloader is not null)
                    CurrentDownloader.IsPaused = true;
                return;
            }
            if (downloadUrlTextBox.Text == string.Empty)
            {
                MessageBox.Show("下载链接不可为空！");
                return;
            }
            if (downloadFileNameTextBox.Text == string.Empty)
            {
                Invoke(() => downloadFileNameTextBox.Text = "未命名文件");
            }
            CurrentDownloader = new XFEDownloader()
            {
                DownloadUrl = downloadUrlTextBox.Text,
                SavePath = $"{ToolFormProfile.XFEDownloaderRootPath}/{downloadFileNameTextBox.Text}",
                FileSegmentCount = threadCountTrackBar.Value
            };
            Invoke(() =>
            {
                downloadProgressBar.Value = 0;
                downloadProcessLabel.Text = "0KB/0KB";
            });
            CurrentDownloader.BufferDownloaded += XFEDownloader_BufferDownloaded;
            var stopWatch = new Stopwatch();
            threadCountTrackBar.Enabled = false;
            downloadUrlTextBox.Enabled = false;
            downloadFileNameTextBox.Enabled = false;
            try
            {
                stopWatch.Start();
                await CurrentDownloader.Download();
                MessageBox.Show($"下载完成！\n总共耗时：{stopWatch.Elapsed.TotalSeconds:F2}秒");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                stopWatch.Stop();
                downloadButton.Text = "开始下载";
                IsDownloadPausedOrCompleted = true;
                threadCountTrackBar.Enabled = true;
                downloadUrlTextBox.Enabled = true;
                downloadFileNameTextBox.Enabled = true;
                CurrentDownloader.Dispose();
            }
        }

        private void XFEDownloader_BufferDownloaded(XFEDownloader sender, FileDownloadedEventArgs e)
        {
            Invoke(() =>
            {
                downloadProgressBar.Value = (int)(e.DownloadedBufferSize / (double)e.TotalBufferSize! * 100);
                downloadProcessLabel.Text = $"{e.DownloadedBufferSize.FileSize()}/{e.TotalBufferSize?.FileSize()}";
            });
        }

        private void ChoicePathButton_Click(object sender, EventArgs e)
        {
            var folderSelector = new FolderBrowserDialog()
            {
                SelectedPath = ToolFormProfile.XFEDownloaderRootPath
            };
            if (folderSelector.ShowDialog() == DialogResult.OK)
            {
                ToolFormProfile.XFEDownloaderRootPath = folderSelector.SelectedPath;
            }
            Invoke(() => fileDownloadPathLabel.Text = $"根目录：{Path.GetFullPath(ToolFormProfile.XFEDownloaderRootPath)}");
        }

        private void OpenFolderButton_Click(object sender, EventArgs e) => Process.Start("explorer.exe", ToolFormProfile.XFEDownloaderRootPath);

        private void ThreadCountTrackBar_Scroll(object sender, EventArgs e) => ToolFormProfile.DownloadThreadCount = threadCountTrackBar.Value;

        private async void DownloadUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!downloadUrlTextBox.Text.IsURL())
                    return;
                var fileName = await downloadUrlTextBox.Text.GetFileNameFromURL();
                Invoke(() => downloadFileNameTextBox.Text = fileName);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }
        }
    }
}
