namespace MauiPageFullScreen;
public static class Controls
{
    private static DeviceServices Control { get; set; } = new();
    public static bool IsFullScreen { get; private set; } = false;
    /// <summary>
    /// Toggle Page Full Screen
    /// </summary>
    public static void ToggleFullScreenStatus()
    {
        if (IsFullScreen)
        {
            IsFullScreen = false;
            Control.RestoreScreen();
        }
        else
        {
            IsFullScreen = true;
            Control.FullScreen();
        }
    }
    public static void FullScreen()
    {
        if (!IsFullScreen)
        {
            Control.FullScreen();
            IsFullScreen = true;
        }
    }
    public static void RestoreScreen()
    {
        if (IsFullScreen)
        {
            Control.RestoreScreen();
            IsFullScreen = false;
        }
    }
    public static void ForceFullScreen()
    {
        Control.FullScreen();
        IsFullScreen = true;
    }
    public static void ForceRestoreScreen()
    {
        Control.RestoreScreen();
        IsFullScreen = false;
    }
}
