using XFEFileEditor.Profiles;
using XFE������չ.NetCore.PermissionExtension;

namespace XFEFileEditor;

public partial class MainForm : Form
{
    public static MainForm? Current { get; set; }
    public readonly TextBox XFEFileTextEditor = new()
    {
        Multiline = true,
        ScrollBars = ScrollBars.Vertical,
        BackColor = Color.FromArgb(30, 30, 30),
        ForeColor = Color.White,
        Location = new Point(0, 31),
        Font = new("Microsoft YaHei UI", SystemProfile.FontSize),
        AllowDrop = true
    };
    public MainForm()
    {
        Current = this;
        InitializeComponent();
        #region �ؼ���ʼ��
        fontSizeNumericUpDown.Value = SystemProfile.FontSize;
        XFEFileTextEditor.Size = new Size(Size.Width, Size.Height - 32);
        XFEFileTextEditor.TextChanged += XFEFileTextEditor_TextChanged;
        XFEFileTextEditor.DragEnter += XFEFileTextEditor_DragEnter;
        XFEFileTextEditor.DragDrop += XFEFileTextEditor_DragDrop;
        if (SystemProfile.IsOpenedByFile)
        {
            LoadFileToEditor();
        };
        Controls.Add(XFEFileTextEditor);
        #endregion
        #region ���ע��
        var fileType = RegistrySystem.GetRegisteredFileType(".xfe");
        if (fileType != "XFEFileType")
            try { AdministratorPermission.GetPermissionAndReboot(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
        #endregion
    }

    private void XFEFileTextEditor_DragDrop(object? sender, DragEventArgs e)
    {
        if (e.Data is not null)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                {
                    MessageBox.Show(file);
                }
            }
        }
    }

    private void XFEFileTextEditor_DragEnter(object? sender, DragEventArgs e)
    {
        if (e.Data is not null)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }

    /// <summary>
    /// ���ļ����Ϊ
    /// </summary>
    /// <returns></returns>
    public bool SaveFileAs()
    {
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "XFE�ļ� (*.xfe)|*.xfe|�����ļ� (*.*)|*.*"
        };
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            SystemProfile.OpenedFilePath = saveFileDialog.FileName;
            File.WriteAllText(saveFileDialog.FileName, XFEFileTextEditor.Text);
            SystemProfile.IsSaved = true;
            Text = SystemProfile.OpenedFileName;
            saveStateLabel.Text = "���и��ľ��ѱ���";
            return true;
        }
        return false;
    }
    /// <summary>
    /// �����ļ����Զ��ж��Ƿ���Ҫ���Ϊ��
    /// </summary>
    /// <returns></returns>
    public bool SaveFile()
    {
        if (SystemProfile.IsOpenedByFile)
        {
            File.WriteAllText(SystemProfile.OpenedFilePath!, XFEFileTextEditor.Text);
            SystemProfile.IsSaved = true;
            Text = SystemProfile.OpenedFileName;
            saveStateLabel.Text = "���и��ľ��ѱ���";
            return true;
        }
        else
        {
            if (SaveFileAs())
            {
                SystemProfile.IsSaved = true;
                Text = SystemProfile.OpenedFileName;
                saveStateLabel.Text = "���и��ľ��ѱ���";
                return true;
            }
            return false;
        }
    }
    /// <summary>
    /// ��SystemProfile�µ��ļ�·�����ı����ؽ��༭��
    /// </summary>
    public void LoadFileToEditor()
    {
        XFEFileTextEditor.TextChanged -= XFEFileTextEditor_TextChanged;
        saveStateLabel.Text = "û���κθĶ�";
        XFEFileTextEditor.Text = File.ReadAllText(SystemProfile.OpenedFilePath!);
        Text = SystemProfile.OpenedFileName;
        XFEFileTextEditor.TextChanged += XFEFileTextEditor_TextChanged;
    }

    private void XFEFileTextEditor_TextChanged(object? sender, EventArgs e)
    {
        SystemProfile.IsSaved = false;
        if (SystemProfile.IsOpenedByFile)
            Text = $"{SystemProfile.OpenedFileName}*";
        else
            Text = "XFE�ļ��༭��*";
        saveStateLabel.Text = "��δ����ĸ���";
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        XFEFileTextEditor.Size = new Size(Size.Width, Size.Height - 32);
    }

    private void FontSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        SystemProfile.FontSize = (int)fontSizeNumericUpDown.Value;
        XFEFileTextEditor.Font = new("Microsoft YaHei UI", SystemProfile.FontSize);
    }

    private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!SystemProfile.IsSaved)
            switch (MessageBox.Show("����δ����ĸ��ģ��Ƿ񱣴�", "����δ����", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    SaveFileToolStripMenuItem_Click(null!, null!);
                    break;
                case DialogResult.No:
                    return;
                default:
                    break;
            }
    }

    private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e) => SaveFileAs();

    private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!SystemProfile.IsSaved)
            switch (MessageBox.Show("����δ����ĸ��ģ��Ƿ񱣴�", "����δ����", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel:
                    return;
                case DialogResult.Yes:
                    if (!SaveFile())
                        return;
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        var openFileDialog = new OpenFileDialog()
        {
            Filter = "XFE�ļ� (*.xfe)|*.xfe|�����ļ� (*.*)|*.*"
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            SystemProfile.OpenedFilePath = openFileDialog.FileName;
            Text = SystemProfile.OpenedFileName;
            LoadFileToEditor();
        }
    }

    private void OptionSettingToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (OptionForm.Current is null || OptionForm.Current.IsDisposed)
        {
            var optionForm = new OptionForm();
            optionForm.Show();
        }
        else
        {
            OptionForm.Current.Focus();
        }
    }

    private void XFEDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (XFEDownloaderForm.Current is null || XFEDownloaderForm.Current.IsDisposed)
        {
            var xFEDownloaderForm = new XFEDownloaderForm();
            xFEDownloaderForm.Show();
        }
        else
        {
            XFEDownloaderForm.Current.Focus();
        }
    }

    private void StringReplaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (StringReplaceToolForm.Current is null || StringReplaceToolForm.Current.IsDisposed)
        {
            var stringReplaceToolForm = new StringReplaceToolForm();
            stringReplaceToolForm.Show();
        }
        else
        {
            StringReplaceToolForm.Current.Focus();
        }
    }
}