using IronPdf;
namespace ironpdf.CustomLogging
{
    public class Section1
    {
        public void Run()
        {
            IronSoftware.Logger.LoggingMode = IronSoftware.Logger.LoggingModes.Custom;
            IronSoftware.Logger.CustomLogger = new CustomLoggerClass("logging");
        }
    }
}