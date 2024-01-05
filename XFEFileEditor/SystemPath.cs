using System.Diagnostics;

namespace XFEFileEditor;

public static class SystemPath
{
    public static string? GetExecutablePath() => Environment.ProcessPath;
    public static string? GetOpenFilePath()
    {
        var args = Environment.GetCommandLineArgs();
        if (args.Length > 1)
            return args[1];
        return null;
    }
}