using XFE������չ.NetCore.PermissionExtension;

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
        #region �ؼ���ʼ��
        fontSizeNumericUpDown.Value = SystemProfile.FontSize;
        XFEFileTextEditor.Size = new Size(Size.Width, Size.Height - 32);
        XFEFileTextEditor.TextChanged += XFEFileTextEditor_TextChanged;
        if (SystemProfile.IsOpenedByFile)
        {
            LoadFileToEditor();
        };
        Controls.Add(XFEFileTextEditor);
        #endregion
        #region ���ע��
        var fileType = RegistrySystem.GetRegisteredFileType(".xfe");
        if (fileType != "XFEFileType")
        {
            var result = MessageBox.Show("��⵽δע��.xfe��׺���ͣ��Ƿ�ע�᣿", "�ļ�δע��", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                try { AdministratorPermission.GetPermissionAndReboot(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion
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
        }
        else
        {
            if (!SaveFileAs())
                return false;
        }
        SystemProfile.IsSaved = true;
        Text = SystemProfile.OpenedFileName;
        saveStateLabel.Text = "���и��ľ��ѱ���";
        return true;
    }
    /// <summary>
    /// ��SystemProfile�µ��ļ�·�����ı����ؽ��༭��
    /// </summary>
    public void LoadFileToEditor()
    {
        saveStateLabel.Text = "û���κθĶ�";
        XFEFileTextEditor.Text = File.ReadAllText(SystemProfile.OpenedFilePath!);
        Text = SystemProfile.OpenedFileName;
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
            LoadFileToEditor();
        }
    }
}