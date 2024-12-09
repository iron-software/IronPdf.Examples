# How to Run & Deploy IronPDF .NET on Azure

***Based on <https://ironpdf.com/get-started/azure/>***


IronPDF is well-suited for creating, editing, and reading PDF documents on Azure, having been extensively tested across various Azure services, including MVC websites, Azure Functions, and more.

#### Azure Functions on Docker

For those utilizing Azure Functions within a Docker container, please consult [this guide](https://ironpdf.com/how-to/docker-linux/).

<hr class="separator">

<p class="main-content__segment-title">Step-by-Step Tutorial</p>

## Project Setup

### Getting Started with IronPDF Installation

Begin by installing IronPDF via NuGet:

- For Azure Functions on Windows, utilize the `IronPdf` package available here: [https://www.nuget.org/packages/IronPdf/](https://www.nuget.org/packages/IronPdf/)
- For Azure Functions on Linux, download the `IronPdf.Linux` package from [https://www.nuget.org/packages/IronPdf.Linux/](https://www.nuget.org/packages/IronPdf.Linux/)

```shell
/Install-Package IronPdf
```

*You can alternatively perform a manual installation of the .dll by downloading directly from [here](https://ironpdf.com/packages/IronPdf.Package.For.azure.zip).*

### Choosing the Appropriate Azure Options

#### Selecting the Proper Azure Hosting Tier

At a minimum, the Azure Basic **B1** tier is required to meet the rendering demands of our users. For high throughput systems, consider upgrading.

Choosing anything other than an **App service plan** might cause issues with IronPdf's PDF rendering capabilities.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Choosing the correct hosting level Azure Tier" class="img-responsive add-shadow" />
    </div>
</div>

#### Configuring the "Run from Package File" Option

Ensure that the `Run from package file` option is **NOT** selected when publishing your Azure Functions application.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="" class="img-responsive add-shadow" />
    </div>
</div>

#### Compatibility with .NET 6

Following the removal of several imaging libraries from .NET 6+, it is important to make adjustments to support legacy API calls:

1.  For Linux, activate `Installation.LinuxAndDockerDependenciesAutoConfig=true;` to ensure the installation of `libgdiplus` on the system.
2.  Insert `<GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>` into your .csproj file.
3.  Create a `runtimeconfig.template.json` file with the following content:

```cs
{
      "configProperties": {
         "System.Drawing.EnableUnixSupport": true
      }
}
```

5. Lastly, add `System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);` at the start of your program.

#### Utilizing Docker on Azure

Using Docker on Azure provides better control over SVG font access and system performance. We highly recommend our detailed [IronPDF Azure Docker Tutorial](https://ironpdf.com/how-to/docker-linux/) for both Linux and Windows setups.

## Example Azure Function Code

This sample demonstrates how to generate logs using Azure's built-in logger:

```cs
[FunctionName("PrintPdf")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext context)
{
    log.LogInformation("Initiating PrintPdf API function...");
    // Insert the license key
    IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
    // Activate custom logging
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;

    IronPdf.Logging.Logger.EnableDebugging = false;
    // Configure IronPdf
    Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
    try
    {
        log.LogInformation("Beginning PDF render...");
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        log.LogInformation("PDF rendering complete...");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "google.pdf" };
    }
    catch (Exception e)
    {
        log.LogError("Rendering error: ", e);
    }

    return new OkObjectResult("OK");
}
```

## Highlighted Issues

### SVG Font Rendering Limitations on Shared Hosting Plans

Rendering of SVG fonts like Google Fonts is not supported on the cheaper, shared Azure web-app tiers. This is due to security restrictions that prevent access to Windows GDI+ graphics objects.

We recommend deploying on a [Windows or Linux Docker Container](https://ironpdf.com/how-to/docker-linux/) or a VPS to address these limitations and achieve optimal font rendering.

### Performance on Azure Free Tier

Hosting on Azure's free and shared tiers, including their consumption plan, is generally slow for PDF rendering tasks. We advocate using at least an Azure B1 or a Premium plan for better performance.

### Creating a Support Ticket

Should you need further help, please refer to the '[How to Make an Engineering Support Request for IronPDF](https://ironpdf.com/troubleshooting/engineering-request-pdf/)' guide.