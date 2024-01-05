using XFE各类拓展.NetCore.InputSimulator;

namespace XFEFileEditor;

public static class Program
{
    public static bool IsOpenedByFile { get; set; }
    private static string? openedFilePath;

    public static string? OpenedFilePath
    {
        get { return openedFilePath; }
        set { if (value is not null) IsOpenedByFile = true; openedFilePath = value; OpenedFileName = Path.GetFileName(value); }
    }
    public static string? OpenedFileName { get; set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        switch (AdministratorPermission.PermissionState)
        {
            case CurrentPermissionState.Administration:
                RegistrySystem.RegisterFileAssociation(".xfe", "XFEFileType", "XFE文件", @"C:\Users\XFEstudio\Desktop\work\LOGO\XFE文件图标.png");
                break;
            case CurrentPermissionState.PermissionDenied:
                MessageBox.Show("无法获取管理员权限，无法注册文件扩展名");
                break;
            case CurrentPermissionState.Normal:
                break;
            default:
                break;
        }
        var fileType = RegistrySystem.GetRegisteredFileType(".xfe");
        if (fileType is null)
        {
            var result = MessageBox.Show("检测到未注册.xfe后缀类型，是否注册？", "文件未注册", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                AdministratorPermission.GetPermissionAndReboot();
        }
        OpenedFilePath = SystemPath.GetOpenFilePath();
        ApplicationConfiguration.Initialize();
        var mainForm = new MainForm()
        {
            Size = new Size(InputSimulator.GetScreenSize().X / 2, InputSimulator.GetScreenSize().Y / 2)
        };
        Application.Run(mainForm);
    }
}