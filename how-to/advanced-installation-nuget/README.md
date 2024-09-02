# IronPDF Advanced Installation Guide

Starting with release v2022.1, IronPdf introduces advanced installation options that cater specifically to various platforms.

Rather than using the standard `IronPDF` package from NuGet, developers can now choose from a variety of targeted IronPDF packages depending on their specific needs. These packages offer the same API but differ in deployment strategies.

What's great is that even if you choose a platform-specific package like IronPdf.Linux for optimized performance on Linux systems, you can still develop using your usual OS such as Windows, within Visual Studio.

## IronPdf Standard NuGet Package

![NuGet Logo](https://ironpdf.com/img.icons8.com/windows/72/000000/nuget.png)
![Linux Logo](https://ironpdf.com/img.icons8.com/color/72/000000/linux--v1.png)
![Docker Logo](https://ironpdf.com/img.icons8.com/color/72/000000/docker.png)
![Azure Logo](https://ironpdf.com/img.icons8.com/fluency/72/000000/azure-1.png)
![AWS Logo](https://ironpdf.com/img.icons8.com/color/72/000000/amazon-web-services.png)
![Ubuntu Logo](https://ironpdf.com/img.icons8.com/color/72/000000/ubuntu--v1.png)
![Mac Logo](https://ironpdf.com/img.icons8.com/color/72/000000/mac-client.png)
![Windows Logo](https://ironpdf.com/img.icons8.com/color/72/000000/windows-logo.png)

This package is the most commonly used. It is configured for quick setup in Visual Studio, making it ideal for a wide range of projects.

[**PM > Install-Package IronPdf**](https://www.nuget.org/packages/IronPdf/)
-   Includes `IronPdf.Slim`
-   Contains Windows-based dependencies for the default Chrome renderer
-   Automatically downloads Windows-specific dependencies at runtime
-   Primarily uses the Chrome renderer
-   Compatible with all platforms, optimizing for Windows without additional downloads
-   Recommended for Windows users or general use
-   Suitable for deployment on any platform

## IronPdf.Slim NuGet Package

![Cloud Logo](https://ironpdf.com/img.icons8.com/color/72/000000/cloud-backup-restore.png)
![Azure Logo](https://ironpdf.com/img.icons8.com/fluency/72/000000/azure-1.png)
![NuGet Logo](https://ironpdf.com/img.icons8.com/windows/72/000000/nuget.png)

Optimal for applications requiring minimal disk space or those distributed across various operating systems. The specific Chromium / WebKit rendering engine will be dynamically downloaded as needed.

[**PM > Install-Package IronPdf.Slim**](https://www.nuget.org/packages/IronPdf.Slim/) 
-   Referenced by all other packages
-   Includes only the core `IronPdf.dll`
-   Excludes OS-specific dependencies, which are fetched at runtime
-   Default setup uses the Chrome renderer on all platforms
-   Ideal for cross-platform applications requiring on-demand dependency downloads
-   Requires internet and disk access during initial runtime
-   Perfect for highly portable applications with variable target environments

## IronPdf.Linux NuGet Package

![Linux Logo](https://ironpdf.com/img.icons8.com/color/72/000000/linux--v1.png)
![Debian Logo](https://ironpdf.com/img.icons8.com/color/72/000000/debian.png)
![Ubuntu Logo](https://ironpdf.com/img.icons8.com/color/72/000000/ubuntu.png)
![CentOS Logo](https://ironpdf.com/img.icons8.com/color/72/000000/centos.png)
![NuGet Logo](https://ironpdf.com/img.icons8.com/windows/72/000000/nuget.png)
![Azure Logo](https://ironpdf.com/img.icons8.com/fluency/72/000000/azure-1.png)
![AWS Logo](https://ironpdf.com/img.icons8.com/color/72/000000/amazon-web-services.png)
![Docker Logo](https://ironpdf.com/img.icons8.com/color/72/000000/docker.png)

Perfect for [Linux deployments](https://ironpdf.com/how-to/linux/), especially in cloud environments like AWS & Azure.

[**PM > Install-Package IronPdf.Linux**](https://www.nuget.org/packages/IronPdf.Linux/)
-   Incorporates `IronPdf.Slim`
-   Includes Linux-specific components for the default Chrome renderer
-   Primarily supports the Chrome renderer
-   Seamless operation on Linux without additional downloads needed
-   Ideal for Linux enthusiasts, particularly those using Docker and cloud technologies

## IronPdf.MacOs & IronPdf.MacOs.ARM NuGet Packages

![Mac Logo](https://ironpdf.com/img.icons8.com/color/72/000000/mac-client.png)
![NuGet Logo](https://ironpdf.com/img.icons8.com/windows/72/000000/nuget.png)

NuGet packages tailored for [Mac compatibility](https://ironpdf.com/how-to/macos/).

[**PM > Install-Package IronPdf.MacOs**](https://www.nuget.org/packages/IronPdf.MacOs/)

[**PM > Install-Package IronPdf.MacOs.ARM**](https://www.nuget.org/packages/IronPdf.MacOs.ARM/)
 
-   Includes `IronPdf.Slim`
-   Contains Mac-specific dependencies for the default Chrome renderer
-   Typically uses the Chrome renderer
-   Well-suited for macOS developers

## IronPdf.Classic NuGet Package

![Time Machine Logo](https://ironpdf.com/img.icons8.com/office/72/000000/time-machine--v1.png)
![Linux Logo](https://ironpdf.com/img.icons8.com/color/72/000000/linux--v1.png)
![Mac Logo](https://ironpdf.com/img.icons8.com/color/72/000000/mac-client.png)
![Windows Logo](https://ironpdf.com/img.icons8.com/color/72/000000/windows-logo.png)
![NuGet Logo](https://ironpdf.com/img.icons8.com/windows/72/000000/nuget.png)

Essential for legacy users who require consistency with IronPDF's HtmlToPdf rendering from before August 2021 using the 2020-2021 WebKit renderer.

[**PM > Install-Package IronPdf.Classic**](https://www.nuget.org/packages/IronPdf.Classic/)
-   Contains both `IronPdf.Slim` and `IronPdf.Native.WebKit`
-   Packs dependencies for the legacy WebKit HTML to PDF renderer
-   Utilizes the traditional WebKit renderer by default