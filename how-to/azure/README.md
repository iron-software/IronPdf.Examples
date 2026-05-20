# Converting HTML to PDF in .NET on Azure

***Based on <https://ironpdf.com/how-to/azure/>***


IronPDF successfully supports the generation, manipulation, and reading of PDF documents across various Azure environments, including MVC websites, Azure Functions, and more.

For those utilizing Azure Functions in Docker Containers, please check out [this comprehensive guide on Azure Docker for Linux](https://ironpdf.com/get-started/ironpdf-docker/).

## Quickstart: Converting HTML to PDF with IronPDF on Azure

Easily convert HTML to PDF on your Azure-based applications with IronPDF. This guide will show you how to transform a website URL into a PDF using IronPDF’s robust API. Ideal for developers aiming to embed PDF functionalities within Azure projects, this example illustrates IronPDF's straightforwardness and efficiency in PDF creation. Implement the following steps to begin producing well-formatted PDFs and propel your Azure project forward efficiently.

```cs
// Title: Simplify HTML to PDF conversion in Azure Functions
var pdfDocument = new IronPdf.ChromePdfRenderer()
    .RenderHtmlAsPdf("<h1>Welcome to Azure!</h1>")
    .SaveAs("azure-output.pdf");
```

---

### Step-by-Step Tutorial

#### Setup Your Project

##### Installing IronPDF

Begin by integrating IronPDF into your project with NuGet:

- For Azure Functions on Windows, utilize the [`IronPdf` package](https://www.nuget.org/packages/IronPdf/)
- For Azure Functions on Linux, opt for the [`IronPdf.Linux` package](https://www.nuget.org/packages/IronPdf.Linux/)

```shell
Install-Package IronPdf
```

*Alternatively, you can download and install the .dll manually via [IronPDF direct download for Azure](https://ironpdf.com/packages/IronPdf.Package.For.azure.zip).*

##### Select Suitable Azure Configuration

###### Choosing the Appropriate Azure Hosting Level

For rendering needs, Azure Basic **B1** tier is sufficient, but higher throughput applications might require an upgrade.

Make sure to choose **App service plan** as the Plan Type to avoid issues with PDF rendering in IronPDF.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Selecting the appropriate Azure hosting level" class="img-responsive add-shadow" />
    </div>
</div>

###### Disable "Run from package file" Checkbox

Ensure `Run from package file` is **NOT** chosen when deploying your Azure Functions.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="Ensure to uncheck 'Run from package file' option" class="img-responsive add-shadow" />
    </div>
</div>

###### Configuring for .NET 6

Due to removal of imaging libraries from .NET 6, it’s crucial to allow legacy API calls:

1. On Linux, activate auto configuration for `libgdiplus` with `Installation.LinuxAndDockerDependenciesAutoConfig = true;`.
2. Modify your `.csproj` to include:
   ```xml
   <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
   ```
3. Create `runtimeconfig.template.json` with:
   ```json
   {
     "configProperties": {
       "System.Drawing.EnableUnixSupport": true
     }
   }
   ```
4. Set this at the start of your program:
   ```csharp
   System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
   ```

###### Leveraging Docker on Azure

For optimal control and performance, consider deploying IronPDF via Docker Containers. Refer to our detailed [guide on IronPDF with Azure Docker](https://ironpdf.com/get-started/ironpdf-docker/) for both Linux and Windows setups.

### Azure Function Code Sample

This function logs activities automatically and facilitates PDF rendering:

```csharp
[FunctionName("GeneratePdf")]
public static async Task<IActionResult> Process(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext context)
{
    log.LogInformation("Initializing GeneratePdf API function...");
    
    // Enter your license key here
    IronPdf.License.LicenseKey = "IRONPDF-YOUR-LICENSE-KEY";

    // Setting up custom logging for debugging
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;

    try {
        log.LogInformation("Starting PDF generation...");
        var renderer = new IronPdf.ChromePdfRenderer();
        var pdf = renderer.RenderUrlAsPdf("https://example.com/");
        
        log.LogInformation("PDF generation complete.");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "example.pdf" };
    } catch (Exception e) {
        log.LogError(e, "Failed to generate PDF");
        return new OkObjectResult("Failed");
    }
}
```

### Common Issues

#### Incompatibility with SVG Fonts on Shared Hosting

Due to security constraints on Azure’s cheaper tiers, loading SVG fonts like Google Fonts is restricted. For optimal font rendering, consider using a Docker Container or a higher-tier VPS on Azure.

#### Azure Free Tier Limitations

The Azure free and shared tiers, including the consumption plan, generally perform poorly for PDF conversion due to their limited computing resources. For better performance, we recommend opting for the Azure B1 or Premium plan.

#### Submitting Engineering Support Requests

To request technical support, refer to our [Engineering Support Request guide for IronPDF](https://ironpdf.com/troubleshooting/engineering-request-pdf/).