using XFE各类拓展.NetCore.InputSimulator;
using XFE各类拓展.NetCore.PermissionExtension;
using XFE各类拓展.NetCore.ProfileExtension;

namespace XFEFileEditor;

public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        XFEProfile.ProfilesRootPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Profiles";
        XFEProfile.LoadProfiles(typeof(SystemProfile)).Wait();
        if (!Directory.Exists(SystemProfile.XFEDownloaderRootPath))
            Directory.CreateDirectory(SystemProfile.XFEDownloaderRootPath);
        switch (AdministratorPermission.PermissionState)
        {
            case CurrentPermissionState.Administration:
                RegistrySystem.RegisterFileAssociation(".xfe", "XFEFileType", "XFE文件", AppDomain.CurrentDomain.BaseDirectory + "XFEFileIcon.ico");
                break;
            case CurrentPermissionState.PermissionDenied:
                MessageBox.Show("无法获取管理员权限，无法注册文件扩展名");
                break;
            case CurrentPermissionState.Normal:
                break;
            default:
                break;
        }
        SystemProfile.OpenedFilePath = SystemPath.GetOpenFilePath();
        ApplicationConfiguration.Initialize();
        var mainForm = new MainForm()
        {
            Size = new Size(InputSimulator.GetScreenSize().X / 2, InputSimulator.GetScreenSize().Y / 2)
        };
        Application.Run(mainForm);
    }
}