# How to Set Up IronPDF Library in a .NET Project

You can integrate the [IronPDF C# Library](https://ironpdf.com/use-case/csharp-pdf-libraries/) into your project in under 5 minutes.

The software is freely available for development through both NuGet and direct downloads. This guide will help you quickly begin using IronPDF in Visual Studio to convert HTML to PDFs within your .NET applications.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Guided Installation of C# PDF Library</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-1-install-ironpdf-via-nuget">Install via NuGet</a></li>
        <li><a href="#anchor-1-2-install-ironpdf-by-dll-download">Direct download installation</a></li>
        <li><a href="#anchor-2-grant-necessary-access-to-file-or-folder">Authorization for specific files or folders</a></li>
        <li><a href="#anchor-3-set-installation-path">Define the installation directory</a></li>
        <li><a href="#anchor-5-microsoft-visual-c-and-windows-compatibility">Support for various OS environments</a></li>
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

## Install IronPDF with NuGet

Follow these steps to add IronPDF to your Visual Studio project using NuGet:

1. Right-click on _References_ under Solution Explorer, then click on Manage NuGet Packages
2. Click Browse and type `"IronPdf"`
3. Choose the IronPDF package and then click install.

```shell
/Install-Package IronPdf
```

IronPDF dependencies needed for deployments on platforms like [Mac](https://ironpdf.com/how-to/macos/), [Linux](https://ironpdf.com/how-to/linux/), [Azure](https://ironpdf.com/how-to/azure/), [Docker](https://ironpdf.com/how-to/docker-linux/), and AWS are detailed in our [advanced installation guidelines](https://ironpdf.com/how-to/advanced-installation-nuget/).

<hr class="separator">

## Install IronPDF with Direct DLL Download

Alternatively, IronPDF can be installed by downloading its DLL files. Here's how:

1. Download and extract the Windows [IronPDF package](https://ironpdf.com/packages/IronPdf.zip) to a chosen directory, e.g., ~/Libs, within your Solution directory
2. Within Visual Studio Solution Explorer, right-click on 'Dependencies', then 'Add Project Reference'. Choose Browse and select the DLL files from the extracted folder.

Here are other IronPDF DLL packages for various platforms:

- [Windows](https://ironpdf.com/packages/IronPdf.zip)
- [Linux](https://ironpdf.com/packages/IronPdf.Linux.zip)
- [MacOS](https://ironpdf.com/packages/IronPdf.MacOs.zip)

### Implement License Key

To activate your license, insert this code at your application's startup, before leveraging IronPDF functionalities.

```cs
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

For other licensing methods, refer to the '[IronPDF License Keys](https://ironpdf.com/how-to/license-keys/)' documentation.

<hr class="separator">

## Set File or Folder Access Rights

It's essential to manage permissions correctly for seamless application operations.

AppDomains encapsulate application details within a process, dictating that each application within the same AppPool needs a dedicated Temporary folder for total isolation.

Adjust permissions via:

1.  Right-click on a file or folder
2.  Choose Properties
3.  Navigate to Security
4.  Click Edit…
5.  Modify permissions as necessary.

<hr class="separator">

## Define Installation Directory

For PDF rendering, IronPDF employs Chromium; however, setting the `TempFolderPath` is vital especially if a "failed rendering" error occurs. Avoid unpacking in the Program Files directory.

**Set `IronPdf.Installation.TempFolderPath`**:

`IronPdf.Installation.TempFolderPath = @"C:\My\Safe\Path";`

Clearing temporary and cache files after setting paths is key to ensure clean redeployments.

**Enforce Environmental Temp Folder Settings**:

```cs
using IronPdf;

// Define the path for temp files for the whole application.
var MyTempPath = @"C:\Safe\Path\";
Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);

// Specify IronPDF's Temp Path
IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");

// Example of creating and saving a PDF.
var Renderer = new IronPdf.ChromePdfRenderer();
using var Doc = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
Doc.SaveAs("example.pdf");
```

<hr class="separator">

## Server and Development Environment Compatibility

### Microsoft Visual C++ and Windows
IronPDF requires Microsoft Visual C++, which can be included with your software installer like MSI. Ensure that both 32 and 64-bit versions are installed on Windows devices. You can [download Microsoft Visual C++](https://support.microsoft.com/en-us/help/2977003/the-latest-supported-visual-c-downloads) here.