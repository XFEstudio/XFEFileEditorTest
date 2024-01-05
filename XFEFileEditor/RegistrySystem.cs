using Microsoft.Win32;

namespace XFEFileEditor;

public static class RegistrySystem
{
    public static string? GetRegisteredFileType(string extension)
    {
        try
        {
            using var key = Registry.ClassesRoot.OpenSubKey(extension);
            if (key != null)
            {
                // 获取关联的文件类型
                var fileType = key?.GetValue("");
                if (fileType is not null)
                    return fileType.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"获取文件扩展名时发生错误：{ex.Message}");
        }
        return null;
    }
    public static void RegisterFileAssociation(string extension, string fileType, string appName, string iconPath = "0")
    {
        try
        {
            // 注册文件关联
            using (var key = Registry.ClassesRoot.CreateSubKey(extension))
            {
                key.SetValue("", fileType);
            }

            // 设置文件类型
            using (var key = Registry.ClassesRoot.CreateSubKey(fileType))
            {
                key.SetValue("", appName + " File");
                key.CreateSubKey("DefaultIcon").SetValue("", $"{SystemPath.GetExecutablePath()},{iconPath}");
                key.CreateSubKey("shell\\open\\command").SetValue("", SystemPath.GetExecutablePath() + " \"%1\"");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"注册文件扩展名时发生错误：{ex.Message}");
        }
    }
    public static void DeleteFileType(string fileType)
    {
        try
        {
            Registry.ClassesRoot.DeleteSubKeyTree(fileType);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error deleting file type: " + ex.Message);
        }
    }

    public static void DeleteFileExtensionAssociation(string extension)
    {
        try
        {
            Registry.ClassesRoot.DeleteSubKeyTree(extension);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error deleting file extension association: " + ex.Message);
        }
    }
}
