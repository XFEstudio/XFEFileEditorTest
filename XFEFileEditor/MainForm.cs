namespace XFEFileEditor;

public partial class MainForm : Form
{
    public readonly TextBox XFEFileTextEditor = new()
    {
        Multiline = true,
        ScrollBars = ScrollBars.Vertical,
    };
    public MainForm()
    {
        InitializeComponent();
        XFEFileTextEditor.Size = Size;
        XFEFileTextEditor.KeyDown += XFEFileTextEditor_KeyDown;
        XFEFileTextEditor.TextChanged += XFEFileTextEditor_TextChanged;
        if (Program.IsOpenedByFile)
        {
            XFEFileTextEditor.Text = File.ReadAllText(Program.OpenedFilePath!);
            Text = Program.OpenedFileName;
        };
        Controls.Add(XFEFileTextEditor);
        var fileType = RegistrySystem.GetRegisteredFileType(".xfe");
        if (fileType is null)
        {
            var result = MessageBox.Show("检测到未注册.xfe后缀类型，是否注册？", "文件未注册", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                AdministratorPermission.GetPermissionAndReboot();
        }
    }

    private void XFEFileTextEditor_TextChanged(object? sender, EventArgs e)
    {
        if (Program.IsOpenedByFile)
            Text = $"{Program.OpenedFileName}*";
        else
            Text = "XFE文件编辑器*";
    }

    private void XFEFileTextEditor_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.S)
        {
            if (Program.IsOpenedByFile)
            {
                File.WriteAllText(Program.OpenedFilePath!, XFEFileTextEditor.Text);
            }
            else
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "XFE文件 (*.xfe)|*.xfe|所有文件 (*.*)|*.*"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Program.OpenedFilePath = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, XFEFileTextEditor.Text);
                }
            }
            Text = Program.OpenedFileName;
            // 阻止事件继续传播，防止TextBox输入内容中的"S"被删除
            e.SuppressKeyPress = true;
        }
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        if (XFEFileTextEditor is not null)
            XFEFileTextEditor.Size = Size;
    }
}