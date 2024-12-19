# Advanced Installation of IronPDF

***Based on <https://ironpdf.com/how-to/advanced-installation-nuget/>***


Starting with version v2022.1, IronPDF introduces specialized installation options for various platforms.

Developers now have the option to select from platform-specific IronPDF packages via NuGet, in addition to the standard `IronPDF` NuGet package. These specialized packages maintain the same API but are tailored to specific deployment environments.

Excitingly, even if a platform-specific package like IronPdf.Linux is implemented for optimized Linux environments, developers can seamlessly continue their work on different operating systems, such as Windows, using Visual Studio.

## Overview of IronPdf NuGet Package

![NuGet](https://img.icons8.com/windows/72/000000/nuget.png)
![Linux](https://img.icons8.com/color/72/000000/linux--v1.png)
![Docker](https://img.icons8.com/color/72/000000/docker.png)
![Azure](https://img.icons8.com/fluency/72/000000/azure-1.png)
![AWS](https://img.icons8.com/color/72/000000/amazon-web-services.png)
![Ubuntu](https://img.icons8.com/color/72/000000/ubuntu--v1.png)
![MacOS](https://img.icons8.com/color/72/000000/mac-client.png)
![Windows](https://img.icons8.com/color/72/000000/windows-logo.png)

The default choice for many, this package is configured for quick setup in Visual Studio, making it ideal for most development projects.

- **[Install IronPdf NuGet Package](https://www.nuget.org/packages/IronPdf/)**
  - Includes IronPdf.Slim
  - Focused on Windows with dependencies for Chrome renderer
  - Automatically installs Windows-specific dependencies upon runtime
  - Primarily uses Chrome as the renderer
  - Supports all platforms; Windows users can proceed without additional installations
  - Recommended for projects where platform specificity is not a concern

## IronPdf.Slim NuGet Package

![Cloud Backup](https://img.icons8.com/color/72/000000/cloud-backup-restore.png)
![Azure](https://img.icons8.com/fluency/72/000000/azure-1.png)
![NuGet](https://img.icons8.com/windows/72/000000/nuget.png)

Designed for minimal disk usage, this package is perfect for applications to be deployed across various operating systems. The required Chromium/WebKit rendering engine is downloaded on-demand at runtime.

- **[Install IronPdf.Slim NuGet Package](https://www.nuget.org/packages/IronPdf.Slim/)**
  - Core `IronPdf.dll` is included, without OS-specific dependencies
  - Dependencies for Windows, Linux, and macOS are fetched during runtime
  - Default renderer is Chrome across all environments
  - Ideal for cross-platform development requiring minimal initial installation footprint
  - Requires internet and disk access during the first runtime on the target system

## IronPdf.Linux NuGet Package

![Linux](https://img.icons8.com/color/72/000000/linux--v1.png)
![Debian](https://img.icons8.com/color/72/000000/debian.png)
![Ubuntu](https://img.icons8.com/color/72/000000/ubuntu.png)
![CentOS](https://img.icons8.com/color/72/000000/centos.png)
![NuGet](https://img.icons8.com/windows/72/000000/nuget.png)
![Azure](https://img.icons8.com/fluency/72/000000/azure-1.png)
![AWS](https://img.icons8.com/color/72/000000/amazon-web-services.png)
![Docker](https://img.icons8.com/color/72/000000/docker.png)

This package is optimally created for Linux deployments, making it suitable for cloud environments like AWS Lambda and Azure Linux functionalities.

- **[Install IronPdf.Linux NuGet Package](https://www.nuget.org/packages/IronPdf.Linux/)**
  - Includes IronPdf.Slim
  - Comes with Linux-specific Chrome dependencies
  - Chrome is the default rendering engine
  - Tailored for cloud enthusiasts and Linux power users

## IronPdf.MacOs & IronPdf.MacOs.ARM NuGet Packages

![MacOS](https://img.icons8.com/color/72/000000/mac-client.png)
![NuGet](https://img.icons8.com/windows/72/000000/nuget.png)

Ensure macOS compatibility by opting for these specific packages.

- **[Install IronPdf.MacOs NuGet Package](https://www.nuget.org/packages/IronPdf.MacOs/)**
- **[Install IronPdf.MacOs.ARM NuGet Package](https://www.nuget.org/packages/IronPdf.MacOs.ARM/)**
  - Includes IronPdf.Slim
  - Contains macOS-specific dependencies for Chrome renderer
  - Supports both standard and ARM macOS architectures
  - Chrome remains the standard renderer
  - Ideally suited for developers using macOS

## IronPdf.Classic NuGet Package

![Time Machine](https://img.icons8.com/office/72/000000/time-machine--v1.png)
![Linux](https://img.icons8.com/color/72/000000/linux--v1.png)
![MacOS](https://img.icons8.com/color/72/000000/mac-client.png)
![Windows](https://img.icons8.com/color/72/000000/windows-logo.png)
![NuGet](https://img.icons8.com/windows/72/000000/nuget.png)

A special package for legacy users, maintaining the HTML to PDF rendering behavior unchanged from IronPDF's earlier versions.

- **[Install IronPdf.Classic NuGet Package](https://www.nuget.org/packages/IronPdf.Classic/)**
  - Bundles both IronPdf.Slim and IronPdf.Native.WebKit
  - Includes all necessary dependencies for legacy WebKit rendering across Windows, Linux, and Mac
  - Defaults to the legacy WebKit renderer ensuring consistent historical behavior