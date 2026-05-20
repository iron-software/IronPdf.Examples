# Setting Up IronPDF in Your .NET Project

***Based on <https://ironpdf.com/get-started/__unlisted__installation__/>***


Incorporate the [C# PDF Library](https://ironpdf.com/use-case/csharp-pdf-libraries/) in under five minutes.

Our no-cost development version is accessible through both NuGet and direct download. By following this guide, you will integrate IronPDF into your .NET project using Visual Studio and commence converting HTML to PDF smoothly.

<div class="learnn-how-section">
<div class="row">
  <div class="col-sm-6">
    <h2>Step-by-Step C# PDF Library Setup</h2>
    <ul class="list-unstyled">
      <li>Install through NuGet</li>
      <li>Install via direct download</li>
      <li>Ensure appropriate folder permissions</li>
      <li>Specify the installation directory</li>
      <li>Receive support for environments like Docker and Linux</li>
    </ul>
  </div>
  <div class="col-sm-6">
    <div class="download-card">
      <a href="https://ironpdf.com/csharp-pdf.pdf" target="_blank">
        <img src="https://ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" style="box-shadow: none; width: 308px; height: 320px;" class="img-responsive learn-how-to-img">
      </a>
    </div>
  </div>
</div>
</div>

<hr class="separator">
<h4 class="tutorial-segment-title">Detailed Installation Guide</h4>

## 1.1. Install IronPDF via NuGet

Follow these steps inside Visual Studio to include the [IronPDF NuGet package](https://www.nuget.org/packages/IronPdf).

1. Right-click _References_ in Solution Explorer, then pick Manage NuGet Packages.
2. Click on Browse and type `"IronPdf"`.
3. Choose the package and proceed with installation.

```shell
/Install-Package IronPdf
```

IronPDF also offers specific NuGet Packages for [Mac](https://ironpdf.com/how-to/macos/), [Linux](https://ironpdf.com/how-to/linux/), [Azure](https://ironpdf.com/how-to/azure/), [Docker](https://ironpdf.com/get-started/ironpdf-docker/) and AWS. Refer to our [advanced NuGet installation instructions](https://ironpdf.com/get-started/advanced-installation-nuget/).

<hr class="separator">

## 1.2. Install IronPDF by Direct DLL Download

Alternatively, you can manually download and configure IronPDF as follows:

1. Download the [IronPDF DLL package](https://ironpdf.com/packages/IronPdf.zip) for Windows and unzip it to a folder like ~/Libs in your Solution directory.
2. Navigate to 'Dependencies' in Solution Explorer on Visual Studio, right-click, select 'Add Project Reference', then Browse and add the DLLs from the unzipped folder.

Explore IronPDF DLL zip packages for various platforms.

- [Windows](https://ironpdf.com/packages/IronPdf.zip)
- [Linux](https://ironpdf.com/packages/IronPdf.Linux.zip)
- [MacOS](https://ironpdf.com/packages/IronPdf.MacOs.zip)

### Implement License Key

Early in your application, typically at startup, include your license key using the following code snippet or refer to the '[License Keys Guidelines](https://ironpdf.com/get-started/license-keys/)' for alternative methods.

```csharp
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

<hr class="separator">

## 2. Configure Appropriate Access To Required Directories

Ensure specific users or roles have the necessary permissions for certain files and directories.

Each .NET [AppDomain](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/application-domains) needs its [TempFolderPath](https://en.wikipedia.org/wiki/Temporary_folder), and programs under the same [AppPool](https://docs.microsoft.com/en-us/iis/manage/configuring-security/application-pool-identities) should not share a TempFolderPath.

To set the permissions:

1. Right-click a file or folder.
2. Go to Properties -> Security.
3. Click on Edit.
4. Adjust the permissions as needed.

<hr class="separator">

## 3. Define the Installation Path

Deploy the necessary components for [HTML to PDF conversion](https://ironpdf.com/tutorials/html-to-pdf/). IronPDF uses Chromium safely for this operation, which is set up automatically. However, if a "failed rendering" error occurs, specify an alternate path for unpacking the browser binaries like the Temp directory.

#### Specify `IronPdf.Installation.TempFolderPath`

To set the right directory for temporary files use:

```csharp
IronPdf.Installation.TempFolderPath = @"C:\My\Safe\Path";
```

Moreover, to manage environmental variables applicable to temporary file paths for IronPDF:

```csharp
using IronPdf;

var MyTempPath = @"C:\Safe\Path\";
Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);

IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");

var Renderer = new IronPdf.ChromePdfRenderer();
using var Doc = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
Doc.SaveAs("example.pdf");
```

Subsequent sections continue to guide through essential settings and compatibility information including IIS, Microsoft Visual C++, Linux, Docker, Azure, AWS Lambda, and macOS integration for a seamless IronPDF implementation in your .NET applications.