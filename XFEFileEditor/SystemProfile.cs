using XFE各类拓展.NetCore.ProfileExtension;

namespace XFEFileEditor;

public static class SystemProfile
{
    private static int fontSize = 9;
    [ProfileProperty]
    public static int FontSize
    {
        get { return fontSize; }
        set { fontSize = value; XFEProfile.SaveProfile(typeof(SystemProfile)); }
    }
}
