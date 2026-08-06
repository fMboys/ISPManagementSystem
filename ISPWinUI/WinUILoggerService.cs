using Serilog;

namespace ISPWinUI
{
    public static class WinUILoggerService
    {
        public static void Info(string message, params object[] args) => Log.Information(message, args);
        public static void Warn(string message, params object[] args) => Log.Warning(message, args);
        public static void Error(Exception ex, string message, params object[] args) => Log.Error(ex, message, args);
        public static void Debug(string message, params object[] args) => Log.Debug(message, args);

    }
}
