# Utilizing IronPDF on macOS

***Based on <https://ironpdf.com/get-started/mac/>***


IronPDF offers comprehensive support for macOS through .NET Standard Libraries, Core applications, and .NET versions 9 through 5.

Please note that development of .NET Framework projects on macOS is not supported because they rely on Xamarin, which is not officially part of the .NET runtime.

Since 2020, IronPDF has seamlessly integrated with all macOS versions without the need for additional dependencies, though we do suggest installing the specific Mac package tailored for your hardware.

### Latest Apple Silicone Mac Machines:
For the more recent Apple Silicon Macs, it's recommended to add the **[IronPdf.MacOs.ARM](https://www.nuget.org/packages/IronPdf.MacOs.ARM)** NuGet package to your project.
```sh
Install-Package IronPdf.MacOs.ARM
```

### Older Intel-based Mac Machines:
Intel-based Macs should utilize the **[IronPdf.MacOs](https://www.nuget.org/packages/IronPdf.MacOs)** NuGet package.
```sh
Install-Package IronPdf.MacOs
```

## Considerations
IronPDF facilitates the development process on macOS with no additional code modifications needed for supporting Apple devices. Developers can build on macOS and deploy across multiple platforms like Windows, Linux, and macOS; however, specific binaries may be necessary for each target environment.

One limitation to bear in mind is that macOS does not yet support multithreaded PDF rendering, typically vital in web server environments, due to the absence of a required message pump in the Mac version of Chromium Embedded Framework.

Our commitment to macOS support is strong as many .NET developers prefer using tools like *Visual Studio for Mac* and *JetBrains Rider* for application development on macOS.

## macOS Specific Configuration & Installation

Apple's shift from Intel processors to their own Apple Silicon chips in 2020 has led to the following package recommendations for Mac developers:
- **[IronPdf.MacOs.ARM](https://www.nuget.org/packages/IronPdf.MacOs.ARM)** for the latest Apple Silicon Macs.
- **[IronPdf.MacOs](https://www.nuget.org/packages/IronPdf.MacOs)** for older Intel-based Macs.
- For environments that use both types of processors, installing both packages is advisable.

## Hardware Specifications

IronPDF relies on Chromium to convert HTML into PDF, mirroring the precision of Chrome's print functionality. Below are the hardware requirements for optimum performance:
- Minimum configuration: 1 core and 1.75 GB of RAM
- Recommended configuration: At least 2 cores and 8 GB of RAM