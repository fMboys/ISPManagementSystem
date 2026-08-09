using Serilog;

namespace ISPWinUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure Serilog, before anything else runs
            string projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..",".."));
            string logPath = Path.Combine(projectRoot, "logs", "log-.txt");

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(logPath,
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 30,          // keep 30 days of logs
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
            .WriteTo.Debug()
            .CreateLogger();

            // --- Global exception handlers ---
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            Log.Information("=== Application starting ===");

            try
            {
                DateTime trialPeriod = DateTime.Now.AddDays(30);

                if (DateTime.Now <= trialPeriod)
                {
                    trialPeriod = trialPeriod.AddDays(-7);
                    if (DateTime.Now > trialPeriod)
                        MessageBox.Show($"The trial period will expire in {(DateTime.Now - trialPeriod).Days} day(s). Please contact support.", "Trial Period Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // To customize application configuration such as set high DPI settings or default font,
                    // see https://aka.ms/applicationconfiguration.
                    ApplicationConfiguration.Initialize();
                    Application.Run(new frmMain());
                }
                else
                {
                    MessageBox.Show("The trial period has ended. Please contact support to obtain a license.", "Trial Period Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
                MessageBox.Show("A fatal error occurred and the application must close.\n\nDetails have been logged.",
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Log.Information("=== Application exiting ===");
                Log.CloseAndFlush();
                Application.Exit();
            }
        }

        // Handles exceptions on UI thread (most WinForms exceptions land here)
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception, "UI Thread");
        }

        // Handles exceptions on non-UI threads (usually fatal)
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception, "AppDomain", isTerminating: e.IsTerminating);
        }

        // Handles exceptions from unawaited async Tasks
        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            HandleException(e.Exception, "Task Scheduler");
            e.SetObserved(); // prevent process crash
        }

        private static void HandleException(Exception ex, string source, bool isTerminating = false)
        {
            if (ex == null) return;

            Log.Error(ex, "Unhandled exception from {Source}. Terminating: {IsTerminating}", source, isTerminating);

            string message = isTerminating
                ? "A critical error occurred and the application must close.\n\nThe issue has been logged."
                : "An unexpected error occurred. You can continue working, but please save your work.\n\nThe issue has been logged.";

            MessageBox.Show(message, "Error", MessageBoxButtons.OK,
                isTerminating ? MessageBoxIcon.Error : MessageBoxIcon.Warning);
        }
    }
}