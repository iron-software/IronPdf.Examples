using IronPdf;
namespace IronPdf.Examples.HowTo.Azure
{
    public static class Section2
    {
        public static void Run()
        {
            [FunctionName("PrintPdf")]
            public static async Task<IActionResult> Run(
                [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
                ILogger log, ExecutionContext context)
            {
                log.LogInformation("Entered PrintPdf API function...");
                // Apply license key
                IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
                // Enable log
                IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
                IronPdf.Logging.Logger.CustomLogger = log;
            
                IronPdf.Logging.Logger.EnableDebugging = false;
                // Configure IronPdf
                Installation.LinuxAndDockerDependenciesAutoConfig = false;
                Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
                try
                {
                    log.LogInformation("About to render pdf...");
                    ChromePdfRenderer renderer = new ChromePdfRenderer();
                    // Render PDF
                    var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
                    log.LogInformation("finished rendering pdf...");
                    return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "google.pdf" };
                }
                catch (Exception e)
                {
                    log.LogError(e, "Error while rendering pdf", e);
                }
            
                return new OkObjectResult("OK");
            }
        }
    }
}