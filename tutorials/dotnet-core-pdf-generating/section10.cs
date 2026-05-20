using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section10
    {
        public static void Run()
        {
            renderer.LoggingOptions.DebugMode        = true;
            renderer.LoggingOptions.LogsToConsole    = true;
            renderer.LoggingOptions.LogFilePath      = "./logs/ironpdf-debug.log";
        }
    }
}