# Setting Up the IronPDF Library in a .NET Project

***Based on <https://ironpdf.com/how-to/installation/>***


Setting up the [C# PDF library](https://ironpdf.com/use-case/csharp-pdf-libraries/) is a quick process, typically taking under 5 minutes.

Available free for development, you can integrate this library into your .NET project via NuGet or a direct download. This guide will help you install IronPDF in Visual Studio, enabling you to start converting HTML to PDF in no time.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Detailed Steps for C# PDF Library Installation</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-1-install-ironpdf-via-nuget">Install through NuGet</a></li>
        <li><a href="#anchor-1-2-install-ironpdf-by-dll-download">Direct download installation</a></li>
        <li><a href="#anchor-2-grant-necessary-access-to-file-or-folder">Provide necessary permissions</a></li> 
        <li><a href="#anchor-3-set-installation-path">Configure the installation path</a></li>
        <li><a href="#anchor-5-microsoft-visual-c-and-windows-compatibility">Support for Docker, Linux, and additional platforms</a></li>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="https://ironpdf.com/csharp-pdf.pdf" target="_blank">
          <img style="box-shadow: none; width: 308px; height: 320px;" src="https://ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" class="img-responsive learn-how-to-img">
        </a>
      </div>
    </div>
  </div>
</div>

<hr class="separator">
<h4 class="tutorial-segment-title">Installation Tutorial</h4>

## 1.1. Install IronPDF via NuGet

Follow these instructions to install the [IronPDF NuGet library](https://www.nuget.org/packages/IronPdf) from within Visual Studio:

1. Open Solution Explorer, right-click on _References_ -> Manage NuGet Packages
2. Click on Browse and type `"IronPdf"`
3. Choose the package and click install.

```shell
/Install-Package IronPdf
```

IronPDF also offers NuGet packages tailored for specific environments like [Mac](https://ironpdf.com/how-to/macos/), [Linux](https://ironpdf.com/how-to/linux/), [Azure](https://ironpdf.com/how-to/azure/), [Docker](https://ironpdf.com/how-to/docker-linux/) and AWS, as detailed in our [comprehensive NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

<hr class="separator">

## 1.2. Install IronPDF by DLL Direct Download

Alternatively, you can install IronPDF through a direct download of its DLL files. Here’s how:

1. Download and extract the Windows [IronPDF DLL package](https://ironpdf.com/packages/IronPdf.zip) to a directory like ~/Libs inside your Solution folder.
2. In Visual Studio's Solution Explorer, right-click on 'Dependencies' -> 'Add Project Reference'. Use Browse to locate and select the DLL files extracted from the zip.

For additional platform-specific DLL packages:

- [Windows](https://ironpdf.com/packages/IronPdf.zip)
- [Linux](https://ironpdf.com/packages/IronPdf.Linux.zip)
- [MacOS](https://ironpdf.com/packages/IronPdf.MacOs.zip)

### Apply License Key

To activate your IronPDF features, insert this code at application startup, before any IronPDF operation:

```cs
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

For different methods of applying the license key, refer to the '[IronPDF License Keys Guide](https://ironpdf.com/how-to/license-keys/)'.

<hr class="separator">

## 2. Grant Necessary Access to File or Folder

Sometimes, permissions need to be adjusted for certain users or services on your system.

For example, each [AppDomain](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/application-domains) requires an independent [TempFolderPath](https://en.wikipedia.org/wiki/Temporary_folder), and Apps in the same [AppPool](https://docs.microsoft.com/en-us/iis/manage/configuring-security/application-pool-identities) must not share TempFolders to remain isolated.

To modify permissions, follow these steps:

1.  Right-click on the file or folder
2.  Choose Properties
3.  Go to Security tab
4.  Click Edit
5.  Adjust permissions as needed.

<hr class="separator">

## 3. Set Installation Path

IronPDF needs to load Chromium to transform [HTML into PDF](https://ironpdf.com/tutorials/html-to-pdf/). The setup for this is automatic, but if there's a "failed rendering" error, it might be necessary to specify an alternative path for unpacking the native browser binaries. The Temp folder usually serves well for this purpose.

Remember, never use Program Files for this purpose.

#### Configuring IronPdf.Installation.TempFolderPath

Specify the TempFolderPath property of the [IronPdf.Installation](https://ironpdf.com/object-reference/api/IronPdf.Installation.html) like this:

`IronPdf.Installation.TempFolderPath = @"C:\My\Safe\Path";`

It’s important to clear all temporary and cache directories after changing paths to avoid clutter or conflicts.

#### Managing Temp Folder Environment Variables

IronPDF might create temporary files during PDF processing. To control this, set the environmental variables for temporary files across your .NET application as shown:

```cs
using IronPdf;

// Assign a custom path for temporary files at the application level.
var MyTempPath = @"C:\Safe\Path\";
Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);

// Assign the TempPath for IronPDF.
IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");

// Example PDF generation code
var Renderer = new IronPdf.ChromePdfRenderer();
using var Doc = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF!</h1>");
Doc.SaveAs("example.pdf");
```

Continue with the guide for further configurations and compatibility information involving servers, cloud environments, and different operating systems.