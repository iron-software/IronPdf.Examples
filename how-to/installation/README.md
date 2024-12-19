# How to Install the IronPDF Library to a .NET Project

***Based on <https://ironpdf.com/how-to/installation/>***


You can incorporate the IronPDF library, a [C# PDF library](https://ironpdf.com/use-case/csharp-pdf-libraries/), into your .NET project in under 5 minutes using this guide.

This freely available library during development can be obtained through NuGet or a direct download. Let's get you started in Visual Studio, converting HTML content to PDF seamlessly.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Guide to Installing the C# PDF Library</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-1-install-ironpdf-via-nuget">Installation via NuGet</a></li>
        <li><a href="#anchor-1-2-install-ironpdf-by-dll-download">Download and Installation</a></li>
        <li><a href="#anchor-2-grant-necessary-access-to-file-or-folder">Configure file or folder permissions</a></li> 
        <li><a href="#anchor-3-set-installation-path">Define the installation path</a></li>
        <li><a href="#anchor-5-microsoft-visual-c-and-windows-compatibility">Enable support for multiple environments</a></li>
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

Follow these directions to add the IronPDF library via [NuGet](https://www.nuget.org/packages/IronPdf):

1. Right-click _References_ in Solution Explorer, and choose Manage NuGet Packages
2. Go to Browse and type `"IronPdf"`
3. Choose to install the selected package.

```shell
/Install-Package IronPdf
```

You can find IronPDF NuGet Packages tailored for various deployments, such as [Mac](https://ironpdf.com/how-to/macos/), [Linux](https://ironpdf.com/how-to/linux/), [Azure](https://ironpdf.com/how-to/azure/), [Docker](https://ironpdf.com/how-to/docker-linux/) and AWS, detailed in our [advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

<hr class="separator">

## 1.2. Install IronPDF by DLL Download

Alternatively, IronPDF can be directly downloaded and installed as described below:

1. Download and extract the Windows IronPDF DLL package from [here](https://ironpdf.com/packages/IronPdf.zip) to a preferable location such as ~/Libs in your Solution directory.
2. In Visual Studio Solution Explorer, right-click 'Dependencies' and choose 'Add Project Reference'. Navigate to and select all the DLLs unpacked from the zip.

Links to IronPDF DLL zip packages for different platforms can be found here:

- [Windows](https://ironpdf.com/packages/IronPdf.zip)
- [Linux](https://ironpdf.com/packages/IronPdf.Linux.zip)
- [MacOS](https://ironpdf.com/packages/IronPdf.MacOs.zip)

### Implementing Your License Key

Insert the following code early in your application's startup sequence to apply the IronPDF license key:

```cs
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

For different methods of applying the license key, refer to our ['IronPDF License Keys Guide'](https://ironpdf.com/how-to/license-keys/).

<hr class="separator">

## 2. Modifying Access Permissions for Files or Folders

Configuring user or role permissions on your system might be necessary.

Applications hosted in the same [AppPool](https://docs.microsoft.com/en-us/iis/manage/configuring-security/application-pool-identities) as well as those across different [AppDomains](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/application-domains) each require their unique [TempFolderPath](https://en.wikipedia.org/wiki/Temporary_folder).

To set up these permissions:

1. Right-click the required file or folder
2. Click Properties > Security
3. Choose Edit…
4. Adjust the permissions as needed.

<hr class="separator">

## 3. Choosing an Installation Path

IronPDF operates by embedding Chromium to convert [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/). This is fully automated, but it's vital to select an appropriate installation path to avoid errors.

### Specifying `IronPdf.Installation.TempFolderPath`

Define the installation path as follows:

`IronPdf.Installation.TempFolderPath = @"C:\Your\Preferred\Path";`

Always clear your temporary and cache directories after updating paths and redeploy a clean version of your application.

### Configuring the System Environment Variables

Set the following environment variables to manage temporary file locations throughout your application:

```cs
using IronPdf;

// Set the path for application scope temporary files.
var MyTempPath = @"C:\Optimal\Path\";
Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);

// Define the IronPDF temporary path.
IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");

// Proceed with PDF generation and editing.
var Renderer = new IronPdf.ChromePdfRenderer();
using var Doc = Renderer.RenderHtmlAsPdf("<h1>Your HTML Content Here</h1>");
Doc.SaveAs("example.pdf");
```

<hr class="separator">

## 4. Permissions and IIS

Grant necessary read and write permissions to the IIS user (IUSER) for both your Installation and Windows Temp Folders, ensuring smooth operation within secured servers.

<hr class="separator">

## 5. Requirement for Microsoft Visual C++ on Windows

To run IronPDF effectively, ensure that Microsoft Visual C++ is installed on your Windows system. This component can usually be found on any advanced Windows installation and is a crucial part for both 32 and 64-bit compatibility.

For the latest downloads, visit the [official Microsoft Visual C++ page](https://support.microsoft.com/en-us/help/2977003/the-latest-supported-visual-c-downloads).

<hr class="separator">

## 6. Linux Compatibility

IronPDF extends full support for Linux platforms, officially supporting environments like [Ubuntu, Debian, CentOS, Fedora, and Amazon Linux 2](https://ironpdf.com/how-to/linux/). Deployment on Linux is comprehensively covered in our guides.

## 7. Docker Compatibility

Implementing IronPDF on [Docker](https://ironpdf.com/how-to/docker-linux/) is streamlined and supported across several Linux distributions as well as Windows.

## 8. Azure Compatibility

IronPDF is fully compatible with Azure, including WebApps, WebJobs, Functions, Docker instances, and VMs. Detailed guidance can be found in the IronPDF [Azure Setup Guide](https://ironpdf.com/how-to/azure/).

## 9. Amazon AWS Lambda Compatibility

Guides and support for setting up IronPDF within [Amazon AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) are extensively provided.

## 10. macOS Compatibility

IronPDF supports macOS development environments, including Rider and Visual Studio for Mac. Our [detailed macOS guide](https://ironpdf.com/how-to/macos/) provides all necessary instructions.