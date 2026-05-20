# Utilizing IronPDF on macOS

***Based on <https://ironpdf.com/get-started/macos/>***


IronPDF offers comprehensive support for macOS through .NET Standard libraries, Core applications, as well as .NET versions 10 to 5.

Development of .NET Framework projects on macOS is not supported, being primarily facilitated by Xamarin and absent from official .NET runtime releases.

Starting in 2020, all macOS versions are fully supported by IronPDF without needing additional dependencies, though a Mac-specific package is recommended for peak performance.

### Current Mac ARM Devices:
For modern Apple Silicon Macs, it is advisable to use the **[IronPdf.MacOs.ARM](https://www.nuget.org/packages/IronPdf.MacOs.ARM)** NuGet package.

```shell
dotnet add package IronPdf.MacOs.ARM
```

### Previous Generation Mac Intel Devices:
For older Intel-based Macs, choose the **[IronPdf.MacOs](https://www.nuget.org/packages/IronPdf.MacOs)** NuGet package.

```shell
dotnet add package IronPdf.MacOs
```

## Key Points
Apple-based developers do not need to modify their code to make it compatible across macOS, Windows, and Linux, though deployment may require additional binaries specific to the target environment.

Multi-threaded PDF rendering on macOS awaits enhancements due to the absence of a message loop in the Mac version of the Chromium Embedded Framework.

Our macOS commitment is demonstrated by the fact that many .NET developers on our team prefer using *Visual Studio for Mac* and *JetBrains Rider* for their development tasks.

## macOS Configuration & Installation Guidance

**NuGet Packages**

From 2020 onwards, as Mac pivoted from Intel to Apple Silicon processors:
- Install the [IronPdf.MacOs.ARM](https://www.nuget.org/packages/IronPdf.MacOs.ARM) package for newer Apple Silicon Macs.
- For Intel Macs, use the [IronPdf.MacOs](https://www.nuget.org/packages/IronPdf.MacOs) package.
- To cover both hardware types, install both aforementioned packages.

**DLL Acquisition**

For scenarios where internet access is restricted, download and manually integrate the DLL:
 
- [IronPdf.MacOs.zip](https://ironpdf.com/packages/IronPdf.MacOs.zip)

## Hardware Recommendations

IronPDF utilizes the Chromium engine to transform HTML into PDFs with precision that mirrors Google Chrome’s print function. This process primarily impacts the following hardware requirements:

- Minimum recommended configuration: 1 Core & 1.75 GB of RAM
- Optimal performance configuration: At least 2 Cores & 8 GB of RAM