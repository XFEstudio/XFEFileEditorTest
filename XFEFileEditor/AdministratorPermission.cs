using System.Diagnostics;
using System.Security.Principal;
using XFE各类拓展.NetCore.FileExtension;

namespace XFEFileEditor;

public static class AdministratorPermission
{
    public static CurrentPermissionState PermissionState { get; private set; }
    public static bool IsAdministrator()
    {
        var identity = WindowsIdentity.GetCurrent();
        var principal = new WindowsPrincipal(identity);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }
    public static void GetPermissionAndReboot()
    {
        try
        {
            "0".WriteIn("pm.xfe");
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Environment.ProcessPath,
                Verb = "runas"  // 使用UAC权限提升
            };
            Process.Start(startInfo);
            Environment.Exit(0);
        }
        catch (Exception ex)
        {
            File.Delete("pm.xfe");
            MessageBox.Show("无法以管理员权限重新启动应用程序: " + ex.Message);
        }
    }
    static AdministratorPermission()
    {
        var result = "pm.xfe".ReadOut();
        var isAdmin = IsAdministrator();
        if (isAdmin)
        {
            PermissionState = CurrentPermissionState.Administration;
        }
        else
        {
            if (result == "-1")
                PermissionState = CurrentPermissionState.Normal;
            else
                PermissionState = CurrentPermissionState.PermissionDenied;
        }
        if (File.Exists("pm.xfe"))
            File.Delete("pm.xfe");
    }
}
public enum CurrentPermissionState
{
    Administration,
    PermissionDenied,
    Normal
}