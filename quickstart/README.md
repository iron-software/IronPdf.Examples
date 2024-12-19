# Getting Started with IronPDF C# PDF Library

***Based on <https://ironpdf.com/docs/docs/>***


IronPDF provides a robust and feature-rich software library that enables meticulous control over the creation, modification, and exporting of PDF files within any project or workflow, addressing every detail of the end-result.

This versatile toolkit supports multiple programming languages including C#, F#, VB.NET, Java, and more, making it the ideal choice for resolving PDF-related challenges. In this guide, we explore the process for **installing IronPDF in C#**.

The library is available for free during the development phase, both through NuGet and direct download. The following directions will guide you on utilizing HTML-to-PDF conversion capabilities within your .NET application.

## Installation Options for IronPDF: Native Mode vs Remote Mode

IronPDF can operate in **Native Mode** and **Remote Mode**, each designed to cater to distinct development settings:

- **Native Mode**: Optimal for local development environments and supports modern versions of Windows, macOS, and Linux. Installation is straightforward by adding the [`IronPdf`](https://www.nuget.org/packages/IronPdf) package from NuGet to your project.
- **Remote Mode (IronPdfEngine)**: Best suited for cloud-based and containerized setups such as Azure, AWS, and Docker. This mode also supports older or less common operating systems like Windows Server 2012 or lesser-known Linux distributions. Install the [`IronPdf.Slim`](https://www.nuget.org/packages/IronPdf.Slim) package and manage the IronPdfEngine within a container.

### Employing IronPDF with Remote Engine

**Understanding the differences between Native & Engine**:
IronPDF incorporates some resource-intensive functions that could be delegated to a remote server. Although IronPdfEngine isn't necessary for IronPDF operations, leveraging it remotely helps avoid compatibility issues with older operating systems concerning Chrome.

**Modifications to Coding Practices with Engine**:
For projects using the Engine, it's advised to use `IronPdf.Slim` to streamline your setup, as the Engine oversees the handling of the bulkier components found in the Native package.

```powershell
PM> Install-Package IronPdf.Slim
```

Once installed, initiate the IronPDF by pointing to your IronPdfEngine instance during application startup:

```csharp
// Example setup assuming IronPdfEngine runs remotely at an IP and port
IronPdf.Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

## Quick Setup Guide for IronPDF in .NET (Native)

Setting up IronPDF in your C# project is simple and quick. It's available for free for development use via both NuGet and direct download. This tutorial will get you started in Visual Studio.

### Detailed Installation Guidelines

#### Method 1: Installing IronPDF via NuGet

To integrate IronPDF via NuGet within Visual Studio:
1. Navigate to Solution Explorer, right-click on _References_, and select Manage NuGet Packages.
2. Use the Browse tab and search for `IronPdf`.
3. Select the package and click install.

```shell
PM> Install-Package IronPdf
```

IronPDF also offers tailored packages for various environments like [Mac](https://ironsoftware.com/csharp/pdf/docs/questions/getting-started-macos/), [Linux](https://ironsoftware.com/csharp/pdf/docs/questions/getting-started-linux/), [Azure](https://ironsoftware.com/csharp/pdf/docs/questions/getting-started-azure/), [Docker](https://ironsoftware.com/csharp/pdf/docs/questions/getting-started-docker-linux/) and AWS extensively covered in our [advanced installation guide](https://ironsoftware.com/csharp/pdf/docs/questions/advanced-nuget-installation/).

#### Method 2: IronPDF Installation via Direct DLL Download

Alternatively, downl