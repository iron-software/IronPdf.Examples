# Comprehensive macOS Support with IronPDF for .NET Core

***Based on <https://ironpdf.com/how-to/macos/>***


IronPDF is pleased to announce robust support for macOS (previously known as "OS X") across .NET Standard Libraries, Core applications, and .NET versions 8, 7, 6, and 5.

However, we currently do not support the development of .NET Framework projects on macOS, as these are managed through Xamarin and are not recognized as an official .NET runtime release.

As of January 2020, IronPDF offers complete out-of-the-box functionality for all macOS versions without the need for additional dependencies.

Developing applications that support macOS requires no additional modifications in the code. Once an app is created on a Mac, it can seamlessly be deployed across Windows, Linux, and macOS platforms, although separate binaries may be necessary depending on the deployment target.

In macOS, the primary distinction is the current lack of support for multithreaded PDF rendering, primarily used on web servers. This limitation stems from the absence of a built-in message pump in the Chromium Embedded Framework for macOS.

Supporting macOS is important to us, as many .NET developers, including our team members, prefer using platforms like *Visual Studio for Mac* and *JetBrains Rider* for their .NET projects on macOS.

## Specific Installation and Configuration for macOS

Over the years, Apple has transitioned through different generations of Intel processors, and starting in 2020, they have begun to shift towards Mac computers with Apple Silicon processors.
- For Intel Macs, download the [IronPDF for macOS on Intel](https://ironpdf.com/packages/IronPdf.MacOs) from the NuGet package.
- For Macs running on Apple Silicon, use the [IronPDF for macOS on Apple Silicon](https://ironpdf.com/packages/IronPdf.MacOs.ARM) NuGet package.
- To accommodate both processor types, both the [IronPDF for macOS on Intel](https://ironpdf.com/packages/IronPdf.MacOs) and [IronPDF for macOS on Apple Silicon](https://ironpdf.com/packages/IronPdf.MacOs.ARM) NuGet packages should be installed.

## Hardware Recommendations

IronPDF leverages the Chromium engine to convert HTML to PDF, ensuring fidelity that is on par with Chrome’s print functionality. The hardware requirements are mainly dictated by the needs of the Chromium engine.
  
- Minimum requirement: At least 1 CPU Core and 1.75 GB of RAM
- Recommended setup: 2 CPU Cores and at least 8 GB of RAM