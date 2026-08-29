using IronPdf.Logging;
using IronPdf;
namespace IronPdf.Examples.GettingStarted.Azure
{
    public static class Section2
    {
        public static void Run()
        {
            // This snippet is a member of a larger component from the accompanying README, not a standalone program.
            // Kept verbatim; see README.md for the full context.
            // [FunctionName("PrintPdf")]
            // public static async Task<IActionResult> Run(
            // [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            // ILogger log, ExecutionContext context)
            // {
            // log.LogInformation("Entered PrintPdf API function...");
            //
            // // Apply license key
            // IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
            //
            // // Enable logging
            // IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
            // IronPdf.Logging.Logger.CustomLogger = log;
            //
            // // Configure IronPdf settings
            // IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
            // IronPdf.Installation.AutomaticallyDownloadNativeBinaries = true;
            // IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
            // IronPdf.Installation.CustomDeploymentDirectory = "/tmp";
            //
            // try
            // {
            // log.LogInformation("About to render PDF...");
            // ChromePdfRenderer renderer = new ChromePdfRenderer();
            // // Render PDF from a URL
            // var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
            // log.LogInformation("Finished rendering PDF...");
            // return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "google.pdf" };
            // }
            // catch (Exception e)
            // {
            // log.LogError(e, "Error while rendering PDF");
            // return new OkObjectResult($"Error while rendering PDF: {e}");
            // }
            // }
        }
    }
}