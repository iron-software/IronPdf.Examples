# How to Convert HTML to PDF with .NET on Azure Using IronPDF

***Based on <https://ironpdf.com/how-to/azure/>***


IronPDF offers robust capabilities for generating, manipulating, and reading PDF documents on Azure, having been rigorously tested across a variety of Azure platforms including MVC websites, Azure Functions, and more.

#### Docker Containers with Azure Functions

If you are deploying Azure Functions within a Docker Container, please consult [this Azure Docker Linux Guide](https://ironpdf.com/how-to/docker-linux/).

<hr class="separator">

<p class="main-content__segment-title">Step-by-Step Guide</p>

## Configuring Your Development Environment

### How to Install IronPDF

To begin, you need to add IronPDF to your project via NuGet:

- For Windows-based Azure Functions, use the `IronPdf` package available at [NuGet IronPdf for Windows](https://www.nuget.org/packages/IronPdf/)
- For Linux-based Azure Functions, use the `IronPdf.Linux` package, accessible at [NuGet IronPdf for Linux](https://www.nuget.org/packages/IronPdf.Linux/)

```shell
Install-Package IronPdf
```

*Alternatively, you can directly download the .dll from the [IronPDF Package for Azure](https://ironpdf.com/packages/IronPdf.Package.For.azure.zip).*

### Select Appropriate Azure Services

#### Choosing the Right Azure Hosting Plan

The Basic Azure Tier **B1** is the recommended starting point for your PDF rendering projects. However, higher demand systems might require more robust hosting options.

Selecting an incorrect plan, such as not choosing an **App service plan**, can lead to failures in PDF rendering by IronPdf.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Selecting the appropriate Azure hosting tier" class="img-responsive add-shadow" />
    </div>
</div>

#### Configuration to Avoid

Ensure that the `Run from package file` option is **NOT** checked when deploying your Azure Functions app.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="Ensure 'Run from package file' is unchecked" class="img-responsive add-shadow" />
    </div>
</div>

#### Adjustments for .NET 6 Support

Due to the removal of imaging libraries from .NET 6+, it's crucial to adjust your project settings to support legacy APIs:

1.  On Linux, enable automatic configuration of Docker dependencies with `Installation.LinuxAndDockerDependenciesAutoConfig = true;`.
2.  Update your .csproj file: `<GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>`.
3.  Create a `runtimeconfig.template.json` in your project directory with:

```json
{
      "configProperties": {
         "System.Drawing.EnableUnixSupport": true
      }
}
```

5.  Add this line at the start of your application: `System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);`.

#### Docker Benefits on Azure

Using Docker Containers on Azure with IronPDF increases control over application performance and font rendering.

For a detailed guide, visit the [IronPDF Docker Guide for Azure](https://ironpdf.com/how-to/docker-linux/).

## Example Azure Function for PDF Generation

Below is a code example that logs activities and generates a PDF:

```csharp
[FunctionName("CreatePdfDocument")]
public static async Task<IActionResult> Execute(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext executionContext)
{
    log.LogInformation("Entering CreatePdfDocument function...");
    // Set the IronPDF license key
    IronPdf.License.LicenseKey = "YOUR-LICENSE-KEY";
    // Customized logger
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;

    IronPdf.Logging.Logger.EnableDebugging = false;
    // Configure the PDF renderer
    var renderer = new ChromePdfRenderer();
    try
    {
        var pdf = renderer.RenderUrlAsPdf("https://www.example.com/");
        log.LogInformation("PDF successfully rendered.");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "example.pdf" };
    }
    catch (Exception e)
    {
        log.LogError(e, "Failed to render PDF.");
    }

    return new OkObjectResult("OK");
}
```

## Limitations and Recommendations

### Limitations on SVG Font Rendering

The Azure platform, particularly in its lower-cost shared hosting tiers, does not support loading SVG fonts due to security restrictions.

For optimal font rendering, consider using [IronPDF’s Guide for Docker Containers](https://ironpdf.com/how-to/docker-linux/).

### Performance in Free and Low-Cost Tiers

Azure's free and basic tiers may not meet the performance needs for PDF rendering. We suggest using at least a B1 tier or a premium plan for better performance, mirroring that of a desktop machine.

### How to Request Technical Support

If you need to open a support ticket, refer to the [IronPDF Engineering Support Request Guide](https://ironpdf.com/troubleshooting/engineering-request-pdf/).