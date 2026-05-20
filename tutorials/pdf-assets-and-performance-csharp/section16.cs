using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section16
    {
        public static void Run()
        {
            IronSoftware.Logger.LoggingMode = IronSoftware.Logger.LoggingModes.Custom;
            IronSoftware.Logger.CustomLogger = new CustomLoggerClass("logging");
        }
    }
}