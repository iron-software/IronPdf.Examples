# IronPDF Offers Full macOS Support for .NET Applications

***Based on <https://ironpdf.com/how-to/macos/>***


IronPDF has expanded its capabilities, now offering comprehensive support for macOS within .NET Standard Libraries and .NET Core applications, specifically for .NET versions 8, 7, 6, and 5.

It's important to note that .NET Framework projects on macOS are not supported as they primarily utilize Xamarin, which does not correspond to an official .NET runtime release.

As of January 2020, IronPDF guarantees complete compatibility with all versions of macOS right out-of-the-box, without the need for any additional installations.

Developers crafting applications for Apple platforms do not need to alter their code. Applications developed on macOS can be seamlessly deployed across Windows, Linux, and macOS platforms, although incorporating additional binaries might be necessary depending on the deployment target.

A specific limitation on macOS is the inability to support multithreaded PDF rendering (a key feature, especially for web servers), due to macOS lacking an integral message pump in its Chromium Embedded Framework.

At IronPDF, macOS support is prioritized as many of our team members, as well as the wider .NET developer community, prefer using tools like *Visual Studio for Mac* and *JetBrains Rider* for their .NET development needs on Apple hardware.

## macOS Specific Installation and Configuration Guide

Apple has transitioned from using Intel processors to its own Apple Silicon processors in Mac computers since 2020.

- For Macs with Intel processors, use the [IronPDF for macOS on Intel](https://ironpdf.com/packages/IronPdf.MacOs) NuGet package.
- For Macs with Apple Silicon processors, use the [IronPDF for macOS on Apple Silicon](https://ironpdf.com/packages/IronPdf.MacOs.ARM) NuGet package.
- To accommodate both processor types, install both the [IronPDF for macOS on Intel](https://ironpdf.com/packages/IronPdf.MacOs) and the [IronPDF for macOS on Apple Silicon](https://ironpdf.com/packages/IronPdf.MacOs.ARM) NuGet packages.

## Recommended Hardware Specifications

The Chromium engine, utilized by IronPDF to transform HTML into PDFs, matches the precision of Chrome's printing capabilities and is the primary consumer of computational resources.

- Minimum system requirements: 1 Core & 1.75 GB of RAM
- Recommended system requirements: At least 2 Cores & 8 GB of RAM or higher