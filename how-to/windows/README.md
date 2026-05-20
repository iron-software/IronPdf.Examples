# IronPDF Compatibility with Windows on .NET Platforms

***Based on <https://ironpdf.com/how-to/windows/>***


IronPDF is compatible with Windows 10, 11, and various versions of Windows Server across multiple .NET frameworks including .NET 8, 7, 6, Core, Standard and Framework.

## Support for Windows Server Versions

**For Windows Server 2022 and 2016**, we provide support in both the Desktop Experience and Core configurations. However, **for Windows Server 2019 and 2012**, support is limited to the Desktop Experience variant.

### Detailed Windows Server Support

- Windows Server 2022 & 2016 include support for both the GUI-enabled ("Desktop experience") and command-line only ("Core") configurations.
- Windows Server 2019 & 2012 are also supported in configurations with a GUI ("Desktop experience").

We are actively working to include support for both the Core and Nano versions of Windows Server. The lack of support is not due to operating system architecture limitations but rather the absence of certain media/graphics DLLs needed by Chromium to convert HTML to PDF. These DLLs are available in the "Desktop" version but not in the minimalist versions of the server.

Additionally, as Windows Nano Server is a more condensed form of Windows Server Core, extending support to Windows Server Core will pave the way for supporting Windows Nano Server in the future.

[Resolving System.Drawing Issues on Windows Nano Server](https://ironpdf.com/troubleshooting/libcef-dll-203/)

### Comparison of Windows Server Editions

Referring to the Microsoft documentation "[Comparison of Standard and Datacenter editions of Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison)", it’s noted that Windows Server DataCenter features all functionalities of Windows Server Standard with added storage benefits. Hence, IronPDF is fully functional on Windows Server DataCenter with the Desktop Experience.

## Windows Specific Installation Guidelines

IronPDF's primary NuGet package depends on the [IronPDF.Native.Chrome.Windows Package](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/), which includes the Chrome binary suitable for both x86 and x64 architectures.

- The [IronPDF NuGet Package](https://www.nuget.org/packages/IronPdf/) is designed to support both x86 and x64 Windows architectures.

For specific runtime targets, unnecessary `/runtimes` directories (either x86 or x64) can be removed.

For those interested in utilizing a newer version of the Chromium engine, please consult the following troubleshooting guide: [IronPdf.Native.UpdatedChrome](https://ironpdf.com/troubleshooting/ironpdf-native-updated-chrome/).

## Recommended Hardware Specifications

The Chromium engine, which IronPDF uses for HTML to PDF conversions, demands significant computational resources for optimal performance. As such, the recommended hardware specifications are:

- Minimum requirement: 1 Core Processor & 1.75 GB of RAM
- Recommended setup: At least 2 Core Processors & 8 GB of RAM or more