using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using System.IO;
using System.Windows.Forms;
namespace HMS.Global_Classes
{
    public class clsLogger
    {
        private static readonly ILogger _logger;

        // Configures the Serilog logger to write daily rolling log files to the app's Logs folder.
        static clsLogger()
        {
            _logger = new LoggerConfiguration()
                .WriteTo.File(
                    Path.Combine(
                        Application.StartupPath,
                        "Logs",
                        "HMS-.log"),
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }


        // Logs an error, including exception details, with an optional message.
        public static void LogError(Exception ex, string message = "")
        {
            _logger.Error(ex, message);
        }


        // Logs an informational message.
        public static void LogInformation(string message)
        {
            _logger.Information(message);
        }


        // Logs a warning message.
        public static void LogWarning(string message)
        {
            _logger.Warning(message);
        }
    }
}