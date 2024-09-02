# IronPDF on macOS with .NET Core

IronPDF now offers comprehensive support for macOS on .NET Standard Libraries, .NET Core applications, and .NET 8, 7, 6 & 5 projects.

It's important to note that IronPDF does not support .NET Framework projects on macOS, as these rely on Xamarin and do not use the native .NET runtime.

As of January 2020, IronPDF supports all versions of macOS right out of the box, requiring no additional dependencies.

Apple users and developers can enjoy seamless support without needing any code modifications. Once an application is developed on macOS, it can be deployed effortlessly across Windows, Linux, and Mac environments, though additional binaries might be required depending on the deployment target.

However, on macOS, multithreaded PDF rendering (which is critical for web servers) is currently unsupported due to the absence of a necessary message pump in the Chromium Embedded Framework for Mac.

Our commitment to macOS support is strong, particularly because many .NET developers, including several team members, prefer using platforms like *Visual Studio for Mac* and *JetBrains Rider* for their .NET development on macOS.

## Specific Configuration & Installation for macOS

Over the years, Apple has used different generations of Intel processors and, beginning in 2020, started integrating Apple Silicon processors into their Mac computers.
- To install on Intel Macs, use the [IronPdf.MacOs](https://ironpdf.com/www.nuget.org/packages/IronPdf.MacOs) NuGet package.
- For Apple Silicon Macs, use the [IronPdf.MacOs.ARM](https://ironpdf.com/www.nuget.org/packages/IronPdf.MacOs.ARM) NuGet package.
- To cater to both Intel and Apple Silicon Macs, install both the [IronPdf.MacOs](https://ironpdf.com/www.nuget.org/packages/IronPdf.MacOs) and [IronPdf.MacOs.ARM](https://ironpdf.com/www.nuget.org/packages/IronPdf.MacOs.ARM) packages.

## Hardware Requirements

IronPDF leverages the Chromium engine to convert HTML to PDF, matching the precision of Chrome’s print function. The primary hardware demands come from running the Chromium engine.

- Minimum requirements: 1 Core & 1.75 GB of RAM
- Recommended setup: 2 Cores & 8 GB of RAM or higher