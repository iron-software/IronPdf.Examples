# IronPDF Advanced Installation Guide

***Based on <https://ironpdf.com/get-started/advanced-installation-nuget/>***


From version 2022.1 onwards, there are enhanced options for installing IronPDF tailored to specific platforms.

Rather than the generic `IronPDF` NuGet package installation, seek out other specialized IronPDF packages on NuGet that better suit your project's needs. The API interaction remains unchanged, however, deployment strategies differ.

A notable feature is that even with a platform-specific package installation, such as IronPdf.Linux for Linux-optimized setups, development can still seamlessly occur on typical operating systems like Windows using Visual Studio.

## IronPdf NuGet Package

![Nuget Icon](https://img.icons8.com/windows/72/000000/nuget.png "NuGet icon")
![Linux Icon](https://img.icons8.com/color/72/000000/linux--v1.png "Linux icon")
![Docker Icon](https://img.icons8.com/color/72/000000/docker.png "Docker icon")
![Azure Icon](https://img.icons8.com/fluency/72/000000/azure-1.png "Azure icon")
![AWS Icon](https://img.icons8.com/color/72/000000/amazon-web-services.png "AWS icon")
![Ubuntu Icon](https://img.icons8.com/color/72/000000/ubuntu--v1.png "Ubuntu icon")
![Mac OS Icon](https://img.icons8.com/color/72/000000/mac-client.png "Mac OS icon")
![Windows Logo](https://img.icons8.com/color/72/000000/windows-logo.png "Windows logo")

This package is the most widely used due to its configuration that speeds up setup in Visual Studio and is suitable for a variety of projects.

[**PM > Install-Package IronPdf**](https://www.nuget.org/packages/IronPdf/)
- *Includes IronPdf.Slim*
- Specifically includes Windows dependencies for Chrome (default) renderer
- Is the default package that automatically downloads Windows-specific dependencies at runtime
- Primarily uses Chrome as the renderer
- Fully compatible with all platforms, with Windows having immediate operational readiness without extra downloads
- Primarily aimed at Windows users

## IronPdf.Slim NuGet Package

![Cloud Backup Icon](https://img.icons8.com/color/72/000000/cloud-backup-restore.png "Cloud backup icon")
![Azure Icon](https://img.icons8.com/fluency/72/000000/azure-1.png "Azure icon")
![Nuget Icon](https://img.icons8.com/windows/72/000000/nuget.png "Nuget icon")

Optimal for minimal disk use or for applications spread across various OS. Chromium/WebKit will be dynamically fetched upon demand during runtime on the target machine.

[**PM > Install-Package IronPdf.Slim**](https://www.nuget.org/packages/IronPdf.Slim/) 
- Referenced by all other packages
- Includes the core IronPdf.dll
- Does not package OS-specific dependencies which are instead fetched at runtime
- Defaults to the Chrome renderer on all platforms
- Ideally suits cross-platform deployments where OS-specific dependencies are fetched during initial runtime
- Requires an internet and disk access when executed stand-alone
- Requires the separate installation of [IronSoftware.Native.PdfModel](https://www.nuget.org/packages/IronSoftware.Native.PdfModel/) package
- Great for applications with unknown deployment targets

## IronPdf.Linux & IronPdf.Linux.ARM NuGet Packages

![Linux Icon](https://img.icons8.com/color/72/000000/linux--v1.png "Linux icon")
![Debian Icon](https://img.icons8.com/color/72/000000/debian.png "Debian icon")
![Ubuntu Icon](https://img.icons8.com/color/72/000000/ubuntu.png "Ubuntu icon")
![CentOS Icon](https://img.icons8.com/color/72/000000/centos.png "CentOS icon")
![Nuget Icon](https://img.icons8.com/windows/72/000000/nuget.png "Nuget icon")
![Azure Icon](https://img.icons8.com/fluency/72/000000/azure-1.png "Azure icon")
![AWS Icon](https://img.icons8.com/color/72/000000/amazon-web-services.png "AWS icon")
![Docker Icon](https://img.icons8.com/color/72/000000/docker.png "Docker icon")

Perfect for [Deploying IronPdf on Linux](https://ironpdf.com/how-to/linux/). Crafted specifically for cloud integrations; performs exceptionally on platforms like AWS & Lambda, as well as Linux-equipped Azure Functions and WebApps.

[**PM > Install-Package IronPdf.Linux**](https://www.nuget.org/packages/IronPdf.Linux/)
[**PM > Install-Package IronPdf.Linux.ARM**](https://www.nuget.org/packages/IronPdf.Linux.ARM)

- *Includes IronPdf.Slim*
- Packages Linux-specific Chrome renderer dependencies
- Defaults to using the Chrome renderer
- Fully supports all platforms, with Linux ready to go without further downloads
- Targeted at Linux power users, particularly those utilizing Docker and cloud services

## IronPdf.MacOs & IronPdf.MacOs.ARM NuGet Packages

![Mac OS Icon](https://img.icons8.com/color/72/000000/mac-client.png "Mac OS icon")
![Nuget Icon](https://img.icons8.com/windows/72/000000/nuget.png "Nuget icon")

Specialized NuGet packages for deploying [IronPdf on macOS](https://ironpdf.com/how-to/macos/)

[**PM > Install-Package IronPdf.MacOs**](https://www.nuget.org/packages/IronPdf.MacOs/)
[**PM > Install-Package IronPdf.MacOs.ARM**](https://www.nuget.org/packages/IronPdf.MacOs.ARM)

- *Includes IronPdf.Slim*
- Packs Mac-specific dependencies for the Chrome renderer
- Defaults to using the Chrome renderer
- Ideal for macOS developers

## IronPdf.UpdatedChrome NuGet Package

![Windows 11 Icon](https://img.icons8.com/color/72/000000/windows-11.png "Windows 11 icon")
![Chrome Icon](https://img.icons8.com/fluency/72/000000/chrome.png "Chrome icon")

For those in need of the newest compatible Chromium versions. Especially useful for the latest Chromium feature and security updates.

Availability and updates may vary.

[**PM > Install-Package IronPdf.UpdatedChrome**](https://www.nuget.org/packages/IronPdf.UpdatedChrome/)
- *Includes IronPdf.Slim*
- *Includes IronSoftware.Native.Model*
- *Includes IronPdf.Native.UpdatedChrome.Windows*
- Enhanced with the latest settings and security features
- Potential compatibility issues may arise
- `SingleProcess` configuration is not available
- Not supported on Windows Server 2012
- Incompatible with 32-bit processes

## IronPdf.UpdatedChrome.Linux & IronPdf.UpdatedChrome.Linux.ARM NuGet Packages

![Linux Icon](https://img.icons8.com/color/72/000000/linux--v1.png "Linux icon")
![Chrome Icon](https://img.icons8.com/fluency/72/000000/chrome.png "Chrome icon")

For users aiming to utilize the most current Chromium version compatible with Linux. Particularly beneficial for the latest updates and features concerning Chromium.

Note: Availability and updates may be subjected to future revisions.

[**PM > Install-Package IronPdf.UpdatedChrome.Linux**](https://www.nuget.org/packages/IronPdf.UpdatedChrome.Linux)
[**PM > Install-Package IronPdf.UpdatedChrome.Linux.ARM**](https://www.nuget.org/packages/IronPdf.UpdatedChrome.Linux.ARM)

- *Includes IronPdf.Slim*
- *Includes IronSoftware.Native.Model*
- *Includes IronPdf.Native.UpdatedChrome.Linux*
- Features new settings and security protections
- May present compatibility challenges
- `SingleProcess` option is unavailable
- Does not support 32-bit processes

## IronPdf.Classic NuGet Package

![Time Machine Icon](https://img.icons8.com/office/72/000000/time-machine--v1.png "Time Machine icon")
![Linux Icon](https://img.icons8.com/color/72/000000/linux--v1.png "Linux icon")
![Mac OS Icon](https://img.icons8.com/color/72/000000/mac-client.png "Mac OS icon")
![Windows Logo](https://img.icons8.com/color/72/000000/windows-logo.png "Windows logo")
![Nuget Icon](https://img.icons8.com/windows/72/000000/nuget.png "Nuget icon")

Essential for legacy customers of IronPDF, prior to August 2021, who prefer unchanged HtmlToPdf conversions using the traditional WebKit renderer from 2020-2021.

[**PM > Install-Package IronPdf.Classic**](https://www.nuget.org/packages/IronPdf.Classic/)
- *Includes IronPdf.Slim and IronPdf.Native.WebKit.*
- Packages dependencies for the Windows, Linux, and Mac platforms specifically for the (legacy) WebKit renderer
- Defaults to the legacy WebKit renderer.

For upgrading to newer Chromium versions, refer to this troubleshooting resource: [IronPdf.Native.UpdatedChrome](https://ironpdf.com/troubleshooting/ironpdf-native-updated-chrome/).