# How to Run HTML to PDF with .NET on Azure?

***Based on <https://ironpdf.com/how-to/azure/>***


Yes, IronPDF can be effectively utilized to create, modify, and read PDF documents in Azure environments. It has been extensively tested across various Azure services, including MVC websites, Azure Functions, and more.

#### Azure Functions on Docker

For those utilizing Azure Functions within a Docker container, please consult [this Azure Docker Linux tutorial](https://ironpdf.com/how-to/docker-linux/) for specific guidance.

<hr class="separator">

<p class="main-content__segment-title">How to Tutorial</p>

## Setting Up Your Project

### Installing IronPDF to Get Started

The initial step involves installing IronPDF via NuGet:

- Use the `IronPdf` package for Windows-based Azure Functions - [NuGet IronPdf package for Windows](https://www.nuget.org/packages/IronPdf/)
- For Linux-based Azure Functions, opt for the `IronPdf.Linux` package - [NuGet IronPdf package for Linux](https://www.nuget.org/packages/IronPdf.Linux/)

```bash
Install-Package IronPdf
```

*Alternatively, you can manually install the .dll through the [IronPDF direct download package for Azure](https://ironpdf.com/packages/IronPdf.Package.For.azure.zip).*

### Select Correct Azure Options

#### Choosing the Correct Hosting Level Azure Tier

The Azure Basic **B1** tier is the base hosting level needed for user rendering demands. For high-volume systems, an upgrade might be necessary.

Selecting a non-compliant Plan Type such as **App service plan** could result in IronPdf not being able to render PDF documents.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Choosing the correct hosting level Azure Tier" class="img-responsive add-shadow" />
    </div>
</div>

#### The "Run from package file" Checkbox

Ensure that `Run from package file` is **NOT** checked when deploying your Azure Functions application.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="Uncheck Run from package file option" class="img-responsive add-shadow" />
    </div>
</div>

#### Configuration for .NET 6

With the removal of imaging libraries from .NET 6, it's crucial to adjust your setup to accommodate legacy API calls:

1. On Linux, enable auto-configuration of Docker dependencies by setting `Installation.LinuxAndDockerDependenciesAutoConfig=true;`
2. Include in your .csproj file for your .NET 6 project: `<GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>`
3. Create a `runtimeconfig.template.json` in your project and populate it:

```csharp
{
      "configProperties": {
         "System.Drawing.EnableUnixSupport": true
      }
}
```

4. At the start of your program, set the legacy API support: `System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);`

#### Using Docker on Azure

To optimize control, font handling, and performance on Azure, consider using Docker. A detailed guide is available in our [IronPDF Azure Docker tutorial](https://ironpdf.com/how-to/docker-linux/) for both Linux and Windows setups.

## Azure Function Code Example

This example demonstrates logging and PDF rendering within an Azure function:

```csharp
[FunctionName("PrintPdf")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext context)
{
    log.LogInformation("Entering PrintPdf API function...");
    // Set license and configure logging
    IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;
    IronPdf.Logging.Logger.EnableDebugging = false;

    // Configuration for IronPdf
    Installation.LinuxAndDockerDependenciesAutoConfig = false;
    Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
    try
    {
        log.LogInformation("Starting PDF render...");
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        log.LogInformation("PDF rendering complete...");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "google.pdf" };
    }
    catch (Exception e)
    {
        log.LogError(e, "Failed during PDF rendering", e);
    }

    return new OkObjectResult("OK");
}
```

## Known Issues

### SVG Fonts on Shared Hosting

SVG fonts, like Google Fonts, are unavailable on shared Azure hosting plans due to security restrictions on accessing Windows GDI+ graphics objects.

To overcome this, consider using a [Docker Container guide for IronPDF](https://ironpdf.com/how-to/docker-linux/) or a VPS on Azure for optimal font rendering.

### Azure Free Tier Performance

The free and shared tiers, and the consumption plan on Azure, are generally too slow for efficient PDF rendering. Instead, we recommend using the Azure B1 hosting or Premium plans, which offer performance comparable to standard desktop machines as they utilize a real browser engine for rendering.

### Creating an Engineering Support Request Ticket

For support, refer to our guide on [How to Make an Engineering Support Request for IronPDF](https://ironpdf.com/troubleshooting/engineering-request-pdf/).