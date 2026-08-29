using IronPdf.Logging;
using IronPdf;
namespace IronPdf.Examples.HowTo.Azure
{
    public static class Section3
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
            // // Configure logging
            // IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
            // IronPdf.Logging.Logger.CustomLogger = log;
            // IronPdf.Logging.Logger.EnableDebugging = false;
            //
            // // Configure IronPdf settings
            // Installation.LinuxAndDockerDependenciesAutoConfig = false;
            // Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
            //
            // try
            // {
            // log.LogInformation("About to render pdf...");
            //
            // // Create a renderer and render the URL as PDF
            // ChromePdfRenderer renderer = new ChromePdfRenderer();
            // var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
            //
            // log.LogInformation("Finished rendering pdf...");
            //
            // // Return the rendered PDF as a file download
            // return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "google.pdf" };
            // }
            // catch (Exception e)
            // {
            // log.LogError(e, "Error while rendering pdf");
            // }
            //
            // return new OkObjectResult("OK");
            // }
        }
    }
}