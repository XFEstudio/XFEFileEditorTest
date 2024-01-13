using XFE������չ.NetCore.InputSimulator;
using XFE������չ.NetCore.PermissionExtension;
using XFE������չ.NetCore.ProfileExtension;

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
                RegistrySystem.RegisterFileAssociation(".xfe", "XFEFileType", "XFE�ļ�", AppDomain.CurrentDomain.BaseDirectory + "XFEFileIcon.ico");
                break;
            case CurrentPermissionState.PermissionDenied:
                MessageBox.Show("�޷���ȡ����ԱȨ�ޣ��޷�ע���ļ���չ��");
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