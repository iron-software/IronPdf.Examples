# IronPDF Integration on macOS

***Based on <https://ironpdf.com/get-started/mac/>***


IronPDF is fully compatible with macOS across various versions from .NET 5 to .NET 9, facilitating development with .NET Standard Libraries and Core applications.

It's important to note, however, that .NET Framework projects on macOS are not supported due to their implementation via Xamarin and lack of official .NET runtime release on this platform.

Since 2020, IronPDF ensures seamless macOS integration without the need for additional installations—though we do advise opting for the macOS-specific package.

### For Latest Apple Silicon Macs:
For users owning the latest Apple Silicon Macs, please enhance your development environment with the **[IronPdf.MacOs.ARM NuGet package](https://www.nuget.org/packages/IronPdf.MacOs.ARM)**.

```shell
Install-Package IronPdf.MacOs.ARM
```

### For Older Mac Intel Machines:
Owners of Intel-based Macs should install the **[IronPdf.MacOs NuGet package](https://www.nuget.org/packages/IronPdf.MacOs)**.

```shell
Install-Package IronPdf.MacOs
```

## Development Insights
No code modifications are required for supporting Apple's ecosystem with your applications. Code written on macOS can be deployed across multiple platforms, including Windows, Linux, and Mac. Although, deployment might necessitate integrating additional binaries specific to each environment.

On macOS, multi-threaded PDF rendering isn’t supported, as the required message pump by Chromium Embedded Framework is absent.

Support for macOS is a priority since it's a favored platform among our .NET developers, who often use tools like *Visual Studio for Mac* and *JetBrains Rider* for .NET coding.

## macOS Specific Configuration & Installation

Historically, Apple has transitioned from Intel processors to its own Apple Silicon processors in 2020.
- For the most recent Apple Silicon models, ensure to install the [IronPdf.MacOs.ARM package](https://www.nuget.org/packages/IronPdf.MacOs.ARM).
- For older Intel models, add the [IronPdf.MacOs package](https://www.nuget.org/packages/IronPdf.MacOs).
- To accommodate both Intel and Apple Silicon Macs, it’s advisable to install both the [IronPdf.MacOs](https://www.nuget.org/packages/IronPdf.MacOs) and [IronPdf.MacOs.ARM](https://www.nuget.org/packages/IronPdf.MacOs.ARM) NuGet packages.

## Recommended Hardware Specification

IronPDF leverages the Chromium engine for converting HTML to PDF, which mirrors the accuracy of Chrome’s print command. Below are the hardware requirements for optimum performance of the Chromium engine:
- Minimum Requirement: 1 Core & 1.75 GB of RAM
- Recommended Setup: 2 Cores & 8 GB of RAM or more