# How to Execute HTML to PDF Conversion with IronPDF on Azure

IronPDF, a library designed specifically for .NET, enables developers to create, manipulate, and read PDF files on Azure. It is robustly tested across a variety of Azure environments, such as MVC websites and Azure Functions.

#### Docker-based Azure Functions

For those using Azure Functions within Docker containers, please consult [this detailed guide](https://ironpdf.com/how-to/docker-linux/).

---

<p class="main-content__segment-title">Step-by-Step Guide</p>

## Project Setup

### Installing IronPDF

To begin, add IronPDF to your project via NuGet:

- Use the `IronPdf` package for Azure Functions on Windows: [NuGet Link](https://www.nuget.org/packages/IronPdf/)
- Use the `IronPdf.Linux` package for Azure Functions on Linux: [NuGet Link](https://www.nuget.org/packages/IronPdf.Linux/)

```shell
/Install-Package IronPdf
```

*You can also manually download the .dll by clicking [here](https://ironpdf.com/packages/IronPdf.Package.For.azure.zip).*

### Configuring Azure Appropriate Settings

#### Selecting an Appropriate Azure Hosting Plan

For basic rendering, Azure's **B1** tier is adequate. However, for systems with high throughput, a higher tier may be necessary.

Ensure you are selecting a **App service plan** to prevent issues with PDF rendering in IronPDF.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Selecting the appropriate Azure hosting level" class="img-responsive add-shadow" />
    </div>
</div>

#### Disable "Run from package file" Option

When deploying Azure Functions apps, ensure that the `Run from package file` option is **NOT** selected.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="" class="img-responsive add-shadow" />
    </div>
</div>

#### Adjustments for .NET 6+

Due to Microsoft's removal of certain imaging libraries from .NET 6 and later, specific configurations are needed:

1. On Linux, enable automatic installation of dependencies via `Installation.LinuxAndDockerDependenciesAutoConfig=true;`
2. Add the line `<GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>` to your .csproj file in your .NET 6 project.
3. Create `runtimeconfig.template.json` in your project with:

```cs
{
    "configProperties": {
        "System.Drawing.EnableUnixSupport": true
    }
}
```

4. At the start of your main program, include: `System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);`

#### Docker Utilization on Azure

Leverage Docker on Azure to enhance control over application performance and gain SVG font access. For both Linux and Windows, refer to our comprehensive [IronPDF Azure Docker tutorial](https://ironpdf.com/how-to/docker-linux/).

## Azure Function Example for PDF Rendering

The following function logs activity and renders a PDF using a website's URL:

```cs
[FunctionName("PrintPdf")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext context)
{
    log.LogInformation("Initiating PrintPdf API function...");
    IronPdf.License.LicenseKey = "LICENSE-KEY-HERE";
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;
    IronPdf.Logging.Logger.EnableDebugging = false;

    try
    {
        var renderer = new ChromePdfRenderer();
        var pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        log.LogInformation("PDF rendering completed...");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "google.pdf" };
    }
    catch (Exception e)
    {
        log.LogError("Failed to render PDF", e);
    }

    return new OkObjectResult("OK");
}
```

## Recognized Limitations

### SVG Font Rendering on Shared Hosting

SVG fonts, such as Google Fonts, are not supported on Azure's lower-cost shared hosting options due to security restrictions related to GDI+ graphics objects.

Prefer deploying on a [Docker Container on Azure](https://ironpdf.com/how-to/docker-linux/) or a specialized VPS for enhanced font capability.

### Performance on Azure Free Tier

Azure's free and lower-tier plans may not provide satisfactory performance for PDF rendering. Opt for at least a B1 or Premium plan for optimal execution similar to a desktop environment's rendering capabilities.

### Requesting Technical Support

For creating a support ticket, follow the steps outlined in '[How to Make an Engineering Support Request for IronPDF](https://ironpdf.com/troubleshooting/engineering-request-pdf)'.