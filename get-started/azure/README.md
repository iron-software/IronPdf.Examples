# Running and Deploying IronPDF .NET on Azure Platforms

***Based on <https://ironpdf.com/get-started/azure/>***


IronPDF is fully compatible with Azure and can be effectively used to generate, access, and modify PDF files. It is successfully integrated across various Azure environments, such as MVC websites and Azure Functions.

### Utilizing Azure Functions with Docker

For implementations involving Azure Functions in Docker Containers, please see [this detailed guide](https://ironpdf.com/how-to/docker-linux/).

---

<p class="main-content__segment-title">Tutorial Guide</p>

## Project Initialization

### Adding IronPDF to Your Project

Begin by installing IronPDF via NuGet:

- For Azure Functions on Windows, the `IronPdf` package is appropriate, accessible at [NuGet IronPdf](https://www.nuget.org/packages/IronPdf/)
- For Azure Functions on Linux, use the `IronPdf.Linux` package available here: [NuGet IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux/)

```shell
/Install-Package IronPdf
```

*Alternatively, you can manually download and install the .dll through [this link](https://ironpdf.com/packages/IronPdf.Package.For.azure.zip).*

### Configuring the Correct Azure Settings

#### Selecting the Optimal Azure Hosting Tier

The Azure Basic **B1** hosting level is the minimum required to meet the rendering needs for most end users. However, for systems requiring high throughput, an upgrade might be necessary.

Incorrect choice of Plan Type, specifically anything other than **App service plan**, could lead to failures in IronPdf document rendering.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Selecting the optimal Azure Hosting Tier" class="img-responsive add-shadow" />
    </div>
</div>

#### Deployment Consideration

Ensure that the `Run from package file` option is **NOT** checked when you publish your Azure Functions applications.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="Ensure 'Run from package file' is not checked" class="img-responsive add-shadow" />
    </div>
</div>

#### Configuring .NET 6

With the removal of imaging libraries from .NET 6 and later versions, various older APIs have become unsupported. Configure your project to still accommodate these:

1. On Linux, ensure libgdiplus is installed by setting `Installation.LinuxAndDockerDependenciesAutoConfig=true;`
2. Include `<GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>` in your project's `.csproj` file.
3. Add a `runtimeconfig.template.json` file with the subsequent content:

```json
{
      "configProperties": {
         "System.Drawing.EnableUnixSupport": true
      }
}
```

4. Use `System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);` to activate this configuration at the start of your program.

#### IronPDF with Docker on Azure

Leverage Docker for more control, SVG font access, and performance enhancements on Azure. Explore our [in-depth Docker tutorial for Azure](https://ironpdf.com/how-to/docker-linux/) covering both Linux and Windows setups.

## Example Azure Function for PDF Printing

Below is how you can integrate PDF printing in an Azure Function, which logs activities to Azure's built-in logger:

```cs
[FunctionName("PrintPdf")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext context)
{
    log.LogInformation("Starting PrintPdf API function...");
    // License key setup
    IronPdf.License.LicenseKey = "LICENSE-KEY-HERE";
    // Configure logging for IronPdf
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;

    IronPdf.Logging.Logger.EnableDebugging = false;
    // Initialize IronPdf settings
    Installation.LinuxAndDockerDependenciesAutoConfig = false;
    Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
    try
    {
        log.LogInformation("Attempting to render a PDF...");
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        // Render and return the PDF
        var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        log.LogInformation("PDF rendering complete.");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "converted-google.pdf" };
    }
    catch (Exception e)
    {
        log.LogError("PDF rendering failed", e);
    }

    return new OkObjectResult("OK");
}
```

## Current Limitations

### Limitations on SVG Fonts in Shared Hosting

SVG font rendering, for instance using Google Fonts, is unsupported in Azure’s lower-cost shared hosting because of security restrictions around accessing Windows GDI+ graphics objects.

For optimal font rendering, consider using either a [Docker Container on Azure](https://ironpdf.com/how-to/docker-linux/) or a VPS.

### Performance in Azure's Lower Service Tiers

The Azure free and shared tiers, as well as the consumption plan, are generally slow for PDF rendering. IronPDF is usually deployed on Azure B1 or Premium plans for performance akin to desktop processing capabilities.

### Support Requests for IronPDF

To file a support request, please refer to the ['IronPDF Engineering Support Request'](https://ironpdf.com/troubleshooting/engineering-request-pdf/) guide for detailed procedures.