using XFE各类拓展.NetCore.ProfileExtension;

namespace XFEFileEditor.Profiles;

public static class ToolFormProfile
{
    private static string xFEDownloaderRootPath = $"{AppDomain.CurrentDomain.BaseDirectory}XFEDownloader";

    [ProfileProperty]
    public static string XFEDownloaderRootPath
    {
        get { return xFEDownloaderRootPath; }
        set { xFEDownloaderRootPath = value; XFEProfile.SaveProfile(typeof(ToolFormProfile)); }
    }

    private static int downloadThreadCount = 5;

    [ProfileProperty]
    public static int DownloadThreadCount
    {
        get { return downloadThreadCount; }
        set { downloadThreadCount = value; XFEProfile.SaveProfile(typeof(ToolFormProfile)); }
    }

    private static string originalTextToReplace = string.Empty;

    [ProfileProperty]
    public static string OriginalTextToReplace
    {
        get { return originalTextToReplace; }
        set { originalTextToReplace = value; XFEProfile.SaveProfile(typeof(ToolFormProfile)); }
    }

    private static string targetTextToReplace = string.Empty;

    [ProfileProperty]
    public static string TargetTextToReplace
    {
        get { return targetTextToReplace; }
        set { targetTextToReplace = value; XFEProfile.SaveProfile(typeof(ToolFormProfile)); }
    }

    private static string replaceFileType = "*.*";

    [ProfileProperty]
    public static string ReplaceFileType
    {
        get { return replaceFileType; }
        set { replaceFileType = value; XFEProfile.SaveProfile(typeof(ToolFormProfile)); }
    }

    private static int replaceFileSelectedEncoding = 0;

    [ProfileProperty]
    public static int ReplaceFileSelectedEncoding
    {
        get { return replaceFileSelectedEncoding; }
        set { replaceFileSelectedEncoding = value; XFEProfile.SaveProfile(typeof(ToolFormProfile)); }
    }
}
