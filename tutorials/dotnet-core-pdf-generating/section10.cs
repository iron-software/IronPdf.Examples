using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section10
    {
        public static void Run()
        {
            // Logging is process-wide, not per renderer.
            IronPdf.Logging.Logger.EnableDebugging = true;
            IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;
            IronPdf.Logging.Logger.LogFilePath = "./logs/ironpdf-debug.log";
        }
    }
}