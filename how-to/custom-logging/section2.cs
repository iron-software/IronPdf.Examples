using IronPdf;
namespace IronPdf.Examples.HowTo.CustomLogging
{
    public static class Section2
    {
        public static void Run()
        {
            // CustomLoggerClass is the reader's own ILogger implementation.
            // Kept verbatim; see README.md for the full context.
            // IronSoftware.Logger.LoggingMode = IronSoftware.Logger.LoggingModes.Custom;
            // IronSoftware.Logger.CustomLogger = new CustomLoggerClass("logging");
        }
    }
}