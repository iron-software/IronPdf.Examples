# Getting Started with IronPDF C# PDF Library

***Based on <https://ironpdf.com/docs/docs/>***


IronPDF is an extensive and versatile Software Library designed to give developers complete control over the generation, editing, and exporting of PDF documents within their projects or workflows. It offers meticulous control over every feature and output detail.

Supporting multiple programming languages including C#, F#, VB.NET, Java, and more, IronPDF is the ideal solution for your PDF-related challenges. This guide focuses on the **C# IronPDF Installation** process.

You can obtain the software free for development purposes through NuGet and direct download. Below are instructions on how to start converting HTML to PDF in your .NET project.

## IronPDF Installation: Native Mode vs Remote Mode

IronPDF provides two modes for rendering PDFs — **Native Mode** and **Remote Mode** — to better suit different deployment needs:

- **Native Mode**: Optimal for developers who prefer local operations, ideal for modern Windows, macOS, and Linux environments. Begin by installing the [IronPdf](https://www.nuget.org/packages/IronPdf) package into your .NET project.
- **Remote Mode (IronPdfEngine)**: Perfect for cloud-based and containerized environments like Azure, AWS, and Docker, facilitating centralized dependency management. Also beneficial for unsupported native or older OS like Windows Server 2012 and lesser-used Linux distributions. Install the [IronPdf.Slim](https://www.nuget.org/packages/IronPdf.Slim) from NuGet and host the `IronPdfEngine` in a container.

### Utilizing IronPDF with Remote Engine

**Differences between Native & Engine:**  
While IronPDF operates independently without the IronPdfEngine, configuring the IronPdfEngine as a remote service is an additional step to circumvent compatibility issues related to Chrome on outdated operating systems or mobile platforms.

**Coding with Engine Mode:**  
When opting for the Engine setup, it is advised to install `IronPdf.Slim` over the complete `IronPdf` package via NuGet. This manages the additional overhead found in the Native package.

```powershell
PM> Install-Package IronPdf.Slim
```

Post installation, configure your application to connect to your remote IronPdfEngine instance with the following startup settings:

```csharp
// Configuration for a remotely hosted IronPdfEngine
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

# How to Install the C# PDF Library into a .NET Project

***Based on <https://ironpdf.com/docs/docs/>***


Setting up the [C# PDF library](https://ironpdf.com/use-case/csharp-pdf-libraries/) is straightforward and quick, typically taking under five minutes.

With free development versions available through both NuGet and direct downloads, this tutorial will guide you through setup in Visual Studio and kickstart your HTML to PDF conversion process.

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Step-by-Step Guide for C# PDF Library Installation</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-1-install-ironpdf-via-nuget">Install via NuGet</a></li>
        <li><a href="#anchor-1-2-install-ironpdf-direct-download">Install through direct download</a></li>
        <li><a href="#anchor-2-grant-necessary-permissions">Allocate the necessary permissions</a></li>
        <li><a href="#anchor-3-establish-installation-path">Determine the installation path</a></li>
        <li><a href="#anchor-5-support-for-docker-linux-more">Support for Docker, Linux, and more</a></li>
      </ul>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="https://ironpdf.com/csharp-pdf.pdf" target="_blank">
          <img style="box-shadow: none; width: 308px; height: 320px;" src="https://ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" class="img-responsive learn-how-to-img">
        </a>
### Apply License Key

Apply your IronPDF license key at your application's startup to initialize the library:

```cs
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

For alternatives to inline code for key application, consider visiting '[IronPDF License Keys](https://ironpdf.com/how-to/license-keys/)' for different methodologies.

<hr class="separator">

## Adjusting File or Folder Permissions

Occasionally, adjusting user or role permissions is necessary for file and folder access:

For distinct instances such as different [AppDomain](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/
application-domains) within your app, separate [TempFolderPath](https://en.wikipedia.org/wiki/Temporary_folder) settings are needed for independent operation since applications sharing the same [AppPool](https://docs.microsoft.com/en_us/iis/manage/configuring-security/application-pool-identities) cannot utilize the same TempFolderPath.

Setting permissions typically involves:

1. Right-clicking the file or folder
2. Navigating to 'Properties'
3. Going to 'Security'
4. Clicking 'Edit…'
5. Setting desired permissions.

<hr class="separator">

## Configuring Installation Path

For IronPDF to render [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/), it internally manages browser dependencies like Chromium:

If encountering a "failed rendering" issue (which is rare), it might necessitate manually specifying where the native browser binaries unpack, with the Temp folder often being adequate:

```cs
IronPdf.Installation.TempFolderPath = @"C:\My\Safe\Path";
```

Always clear all temporary and cache directories after modifications to ensure a clean application deployment.

Additionally, setting the Temp Folder Environment Variable at the Application Scope ensures control over where temporary files are stored:

```cs
using IronPdf;

// Define a custom temporary files path for the entire application.
var MyTempPath = @"C:\Safe\Path";
Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);

// Specify the IronPDF Temporary path.
IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");

// Example PDF generation using HTML content.
var Renderer = new IronPdf.ChromePdfRenderer();
using var Doc = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
Doc.SaveAs("example.pdf");
```

This comprehensive guide will hopefully streamline your installation process and get you swiftly started on generating and managing PDF files with IronPDF in your .NET projects.