internal static class AppMain
{
    [STAThread]
    private static void Main()
    {
        Directory.SetCurrentDirectory(AppContext.BaseDirectory);
        Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using GameMain app = new();
        app.Run();
    }
}
