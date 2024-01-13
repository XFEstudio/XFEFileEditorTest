using XFE各类拓展.NetCore.ProfileExtension;

namespace XFEFileEditor;

public static class SystemProfile
{
    #region 需要储存配置文件
    private static int fontSize = 9;
    /// <summary>
    /// 字体大小
    /// </summary>
    [ProfileProperty]
    public static int FontSize
    {
        get { return fontSize; }
        set { fontSize = value; XFEProfile.SaveProfile(typeof(SystemProfile)); }
    }
    private static string xFEDownloaderRootPath = $"{AppDomain.CurrentDomain.BaseDirectory}XFEDownloader";

    [ProfileProperty]
    public static string XFEDownloaderRootPath
    {
        get { return xFEDownloaderRootPath; }
        set { xFEDownloaderRootPath = value; XFEProfile.SaveProfile(typeof(SystemProfile)); }
    }
    private static int downloadThreadCount = 5;

    [ProfileProperty]
    public static int DownloadThreadCount
    {
        get { return downloadThreadCount; }
        set { downloadThreadCount = value; XFEProfile.SaveProfile(typeof(SystemProfile)); }
    }
    #endregion
    #region 无需储存的配置文件
    /// <summary>
    /// 是否是从文件打开的本程序
    /// </summary>
    public static bool IsOpenedByFile { get; set; }
    private static string? openedFilePath;
    /// <summary>
    /// 打开文件的路径（如果是从文件打开的话）
    /// </summary>
    public static string? OpenedFilePath
    {
        get { return openedFilePath; }
        set { if (value is not null) IsOpenedByFile = true; openedFilePath = value; OpenedFileName = Path.GetFileName(value); }
    }
    /// <summary>
    /// 打开文件的名称
    /// </summary>
    public static string? OpenedFileName { get; private set; }
    public static bool IsSaved { get; set; } = true;
    #endregion
}
