# Enhanced Support for macOS in IronPDF with .NET Core

***Based on <https://ironpdf.com/how-to/macos/>***


IronPDF now offers comprehensive compatibility across macOS (*previously referred to as "OS X"*) for .NET Standard Libraries and Core applications, including .NET 8, 7, 6, and 5.

Development for .NET Framework projects on macOS is not supported since they rely on Xamarin and do not constitute an official .NET runtime release.

As of January 2020, IronPDF delivers full support for all macOS versions right out of the box without the need for additional dependencies.

No modifications to the codebase are necessary to accommodate Apple users or developers. Once an application is developed on macOS, it can be seamlessly deployed on Windows, Linux, or Mac environments, though additional binaries might be required based on the deployment target.

However, macOS does have a limitation regarding multithreaded PDF rendering support, notably in web server scenarios, due to the absence of a message pump in the Chromium Embedded Framework for Mac.

Our commitment to supporting macOS stems from its popularity among .NET developers, including some of our own team members, who prefer using tools like *Visual Studio for Mac* and *JetBrains Rider* for development on this platform.

## Specific Configuration & Installation for macOS

Over the years, Apple has integrated different generations of Intel processors, and since 2020, began equipping Mac computers with their own Apple Silicon processors.
- For Macs with Intel processors, install the [IronPDF for macOS on Intel](https://ironpdf.com/packages/IronPdf.MacOs) NuGet package.
- For Macs with Apple Silicon processors, install the [IronPDF for macOS on Apple Silicon](https://ironpdf.com/packages/IronPdf.MacOs.ARM) NuGet package.
- To ensure compatibility with both Intel and Apple Silicon Macs, it's advisable to install both the [IronPDF for macOS on Intel](https://ironpdf.com/packages/IronPdf.MacOs) and [IronPDF for macOS on Apple Silicon](https://ironpdf.com/packages/IronPdf.MacOs.ARM) NuGet packages.

## Hardware Requirements

The Chromium engine, used by IronPDF to convert HTML to PDF, demands significant computing resources for rendering PDFs with accuracy comparable to Chrome’s print function.
- Minimum system requirements include 1 Core and 1.75 GB of RAM.
- For optimal performance, a configuration with at least 2 Cores and 8 GB of RAM is recommended.