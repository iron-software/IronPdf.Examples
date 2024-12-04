# IronPDF Compatibility with Windows Platforms for .NET Usage

***Based on <https://ironpdf.com/how-to/windows/>***


IronPDF fully supports Windows 10, 11, and Windows Server operating environments for various .NET versions including .NET 8, 7, 6, Core, Standard, and Framework.

## Support for Windows Server

For **Windows Server 2022 and 2016** versions, IronPDF extends compatibility both for installations with a graphical user interface ("Desktop Experience") and for command-line only environments ("Core"). However, compatibility with **Windows Server 2019 and 2012** is available strictly for the Desktop Experience setup.

**Coverage for Windows Server 2022 & 2016:**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Both UI and Core installations for Windows Server 2022 & 2016.

**Coverage for Windows Server 2019 & 2012:**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> UI ("Desktop experience") for Windows Server 2019 & 2012
- <i class="fa-regular fa-circle-xmark" style="color: #ff4abd;"></i> Core installations for Windows Server 2019 & 2012 not supported.

Our efforts to support Core and Nano editions of Windows Server are in progress. The challenge mainly lies in the dependencies on certain media/graphics DLLs that the Chromium engine requires. These are typically absent in the more minimalistic Core versions.

On a related note, once support for Windows Server Core is solidified, IronPDF will also aim to extend support to Windows Nano Server, a more condensed form of Windows Server Core.

[Resolving System.Drawing Issues on Windows Nano Server](https://ironpdf.com/troubleshooting/libcef-dll-203/)

### Windows Server Standard & DataCenter Variants

As per Microsoft's "[Comparison of Standard and Datacenter editions of Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison)", Windows Server DataCenter builds upon the Standard edition by adding enhanced storage capabilities. IronPDF functions seamlessly on Windows Server DataCenter with Desktop Experience.

## Specific Installation for Windows 

The primary IronPDF NuGet package leverages the [IronPDF.Native.Chrome.Windows Package](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/), which supports the Chrome browser binaries needed for both x86 and x64 Windows architectures.

- The core [IronPDF NuGet Package](https://www.nuget.org/packages/IronPdf/) is compatible with both x86 and x64 configurations.

Should there be a need to target a specific system architecture, it is possible to remove the irrelevant `/runtimes` directory (either x86 or x64).

## Recommended Hardware Specifications

Since IronPDF utilizes the Chromium engine to convert HTML to PDFs with high fidelity, resembling Google Chrome’s printing functionality, the specifications needed are mostly to accommodate Chromium's operational requirements.

- Minimum Specifications: 1 Core & 1.75 GB of RAM
- Recommended Specifications: 2 Cores & 8 GB of RAM or higher