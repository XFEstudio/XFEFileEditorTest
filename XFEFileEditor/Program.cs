using XFE������չ.NetCore.InputSimulator;

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
        OpenedFilePath = SystemPath.GetOpenFilePath();
        ApplicationConfiguration.Initialize();
        var mainForm = new MainForm()
        {
            Size = new Size(InputSimulator.GetScreenSize().X / 2, InputSimulator.GetScreenSize().Y / 2)
        };
        Application.Run(mainForm);
    }
}