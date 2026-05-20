# Running and Deploying IronPDF .NET on Azure Functions

***Based on <https://ironpdf.com/get-started/azure/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/fluency/96/000000/azure-1.png">
        </div>
    </div>
</div>

IronPDF supports the creation, modification, and reading of PDF files seamlessly on Azure. It has been efficiently utilized across various Azure services, including MVC websites and Azure Functions.

<hr class="separator">

<p class="main-content__segment-title">Step-by-Step Guide</p>

## Setting Up IronPdf Package

Azure Function Apps can operate under three environments: **Linux**, **Windows**, and **Container**. This tutorial provides steps for integrating IronPdf into all these environments, with a special recommendation for using Azure Function App Container for its isolation benefits. Start by choosing the suitable package for installation.

### Azure Function App Container

Azure Function App Container is the simplest approach to implement IronPdf, thus it is highly recommended.

- [IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux/) package

<div class="copy-nuget-section md-body net" data-toggle="tooltip" data-placement="top" data-copy-text="Click to copy" data-copied-text="Copied to clipboard" data-bs-original-title="Copied to clipboard" data-bs-title="Copied to clipboard">
  <pre class="install-script">Install-Package IronPdf.Linux</pre>
</div>

**Docker File Configuration**

Adjust the Docker file to fit the Linux distribution in use. Detailed setup instructions can be found in [this guide](https://ironpdf.com/get-started/ironpdf-docker/).

### Azure Function App (Windows)

For the standard setup, use the [IronPdf](https://www.nuget.org/packages/IronPdf/) package and ensure the **Run from package file** option is not selected. This mode packages the project as a ZIP file which might conflict with IronPdf’s configurations. Alternatively, if the ZIP deployment is essential, opt for the [IronPdf.Slim](https://www.nuget.org/packages/IronPdf.Slim/) package.

- [IronPdf](https://www.nuget.org/packages/IronPdf/) package

```shell
Install-Package IronPdf
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-package-file.webp" alt="" class="img-responsive add-shadow" />
    </div>
</div>

### Azure Function App (Linux)

For Azure Function App (Linux), deploying as a ZIP file is the default and cannot be altered. This procedure parallels the **Run from package file** mode in Windows.

- [IronPdf.Slim](https://www.nuget.org/packages/IronPdf.Slim/) package

<div class="copy-nuget-section md-body net" data-toggle="tooltip" data-placement="top" data-copy-text="Click to copy" data-copied-text="Copied to clipboard" data-bs-original-title="Copied to clipboard" data-bs-title="Copied to clipboard">
  <pre class="install-script">Install-Package IronPdf.Slim</pre>
</div>

<hr>

## Select Appropriate Azure Options

### Selecting the Right Hosting Tier

The minimum Azure hosting tier suitable for rendering is Azure Basic **B1**. For systems requiring higher throughput, an upgrade may be necessary.

**Important**: Select an **App service plan** to avoid issues with PDF rendering in IronPdf.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/azure/azure-hosting-tier.webp" alt="Choosing the correct hosting level Azure Tier" class="img-responsive add-shadow" />
    </div>
</div>

### Configuration for .NET 6

Due to the removal of imaging libraries from .NET 6+, it is vital to configure your application to support legacy API calls:

1. Enable automatic configuration of Linux dependencies for Docker with `Installation.LinuxAndDockerDependenciesAutoConfig=true;` to ensure `libgdiplus` is available.
2. Modify the .csproj file to include:

```xml
<GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
```

3. Add a `runtimeconfig.template.json` in your project filled with:

```json
{
  "configProperties": {
    "System.Drawing.EnableUnixSupport": true
  }
}
``` 

4. At the program's onset, execute:

```csharp
System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
```

<hr>

## Azure Function PDF Conversion Example

Below is an example converting HTML to PDF, utilizing Azure’s native logging tools (`ILogger log`).

```csharp
[FunctionName("PrintPdf")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log, ExecutionContext context)
{
    log.LogInformation("Starting the PrintPdf API function...");
    
    // Activate the license key
    IronPdf.License.LicenseKey = "IRONPDF-YOUR-LICENSE-KEY-HERE";

    // Set up logging
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.Custom;
    IronPdf.Logging.Logger.CustomLogger = log;

    // Establish IronPdf settings
    IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
    IronPdf.Installation.AutomaticallyDownloadNativeBinaries = true;
    IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
    IronPdf.Installation.CustomDeploymentDirectory = "/tmp";
    
    try
    {
        log.LogInformation("Initiating PDF rendering...");
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        // Generate PDF from a specified URL
        var pdf = renderer.RenderUrlAsPdf("https://www.example.com/");
        log.LogInformation("PDF rendering completed.");
        return new FileContentResult(pdf.BinaryData, "application/pdf") { FileDownloadName = "example.pdf" };
    }
    catch (Exception e)
    {
        log.LogError(e, "Failed during PDF rendering");
        return new OkObjectResult($"PDF rendering failure: {e}");
    }
}
```

### Installation Configuration Details

- **LinuxAndDockerDependenciesAutoConfig**: Ensures necessary dependencies are available for the Chrome Engine in non-GUI and container environments.
- **AutomaticallyDownloadNativeBinaries**: Facilitates the runtime download of the necessary Chrome binary, particularly when using the IronPdf.Slim package.
- **CustomDeploymentDirectory**: Essential for environments with restricted write permissions.

<hr>

## Known Challenges

### SVG Font Loading Issue on Shared Hosting

Azure's shared web-app tiers do not support SVG fonts due to security restrictions on GDI+ graphics access. For optimal font rendering, consider using a [Windows or Linux Docker Container](https://ironpdf.com/get-started/ironpdf-docker/) or a VPS.

### Performance Limitations on Azure Free Tier

Azure’s free and shared hosting plans, including the consumption plan, are unsuitable for PDF rendering due to performance limitations. Opt for Azure B1 or a Premium plan for adequate processing power, akin to desktop-level performance.

### How to Request Engineering Support

For technical support, refer to the '[Requesting Engineering Support for IronPDF](https://ironpdf.com/troubleshooting/engineering-request-pdf/)' guide.