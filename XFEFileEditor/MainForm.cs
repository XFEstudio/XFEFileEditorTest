using XFE各类拓展.NetCore.PermissionExtension;

namespace XFEFileEditor;

public partial class MainForm : Form
{
    public readonly TextBox XFEFileTextEditor = new()
    {
        Multiline = true,
        ScrollBars = ScrollBars.Vertical,
        BackColor = Color.FromArgb(30, 30, 30),
        ForeColor = Color.White,
        Location = new Point(0, 31),
        Font = new("Microsoft YaHei UI", SystemProfile.FontSize)
    };
    public MainForm()
    {
        InitializeComponent();
        #region 控件初始化
        fontSizeNumericUpDown.Value = SystemProfile.FontSize;
        XFEFileTextEditor.Size = new Size(Size.Width, Size.Height - 32);
        XFEFileTextEditor.TextChanged += XFEFileTextEditor_TextChanged;
        if (SystemProfile.IsOpenedByFile)
        {
            LoadFileToEditor();
        };
        Controls.Add(XFEFileTextEditor);
        #endregion
        #region 检测注册
        var fileType = RegistrySystem.GetRegisteredFileType(".xfe");
        if (fileType != "XFEFileType")
        {
            var result = MessageBox.Show("检测到未注册.xfe后缀类型，是否注册？", "文件未注册", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                try { AdministratorPermission.GetPermissionAndReboot(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion
    }
    /// <summary>
    /// 将文件另存为
    /// </summary>
    /// <returns></returns>
    public bool SaveFileAs()
    {
        var saveFileDialog = new SaveFileDialog
        {
            Filter = "XFE文件 (*.xfe)|*.xfe|所有文件 (*.*)|*.*"
        };
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            SystemProfile.OpenedFilePath = saveFileDialog.FileName;
            File.WriteAllText(saveFileDialog.FileName, XFEFileTextEditor.Text);
            return true;
        }
        return false;
    }
    /// <summary>
    /// 保存文件（自动判断是否需要另存为）
    /// </summary>
    /// <returns></returns>
    public bool SaveFile()
    {
        if (SystemProfile.IsOpenedByFile)
        {
            File.WriteAllText(SystemProfile.OpenedFilePath!, XFEFileTextEditor.Text);
        }
        else
        {
            if (!SaveFileAs())
                return false;
        }
        SystemProfile.IsSaved = true;
        Text = SystemProfile.OpenedFileName;
        saveStateLabel.Text = "所有更改均已保存";
        return true;
    }
    /// <summary>
    /// 将SystemProfile下的文件路径的文本加载进编辑器
    /// </summary>
    public void LoadFileToEditor()
    {
        saveStateLabel.Text = "没有任何改动";
        XFEFileTextEditor.Text = File.ReadAllText(SystemProfile.OpenedFilePath!);
        Text = SystemProfile.OpenedFileName;
    }

    private void XFEFileTextEditor_TextChanged(object? sender, EventArgs e)
    {
        SystemProfile.IsSaved = false;
        if (SystemProfile.IsOpenedByFile)
            Text = $"{SystemProfile.OpenedFileName}*";
        else
            Text = "XFE文件编辑器*";
        saveStateLabel.Text = "有未保存的更改";
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
            switch (MessageBox.Show("存在未保存的更改，是否保存", "更改未保存", MessageBoxButtons.YesNoCancel))
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
            switch (MessageBox.Show("存在未保存的更改，是否保存", "更改未保存", MessageBoxButtons.YesNoCancel))
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
            Filter = "XFE文件 (*.xfe)|*.xfe|所有文件 (*.*)|*.*"
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            SystemProfile.OpenedFilePath = openFileDialog.FileName;
            LoadFileToEditor();
        }
    }
}