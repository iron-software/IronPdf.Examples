using IronPdf;
namespace IronPdf.Examples.HowTo.CustomLogging
{
    public static class Section1
    {
        public static void Run()
        {
            IronSoftware.Logger.LoggingMode = IronSoftware.Logger.LoggingModes.Custom;
            IronSoftware.Logger.CustomLogger = new CustomLoggerClass("logging");
        }
    }
}