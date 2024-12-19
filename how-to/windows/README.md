# IronPDF Compatibility for Windows Platforms using .NET

***Based on <https://ironpdf.com/how-to/windows/>***


IronPDF is compatible with multiple Windows versions, including Windows 10, Windows 11, and Windows Server, working with .NET versions 8, 7, 6, Core, Standard, and Framework.

## Support for Windows Server

IronPDF facilitates support for **Windows Server 2022 and 2016** in both Desktop Experience and Core versions, though it only extends support to **Windows Server 2019 and 2012** for the Desktop Experience configuration.

**For Windows Server 2022 & 2016**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Available for Windows Server 2022 & 2016 using the Desktop Experience.
- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Functional for Windows Server 2022 & 2016 in a command-line environment ("Core").

**For Windows Server 2019 & 2012**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Supported for Windows Server 2019 & 2012 with a Desktop Experience.
- <i class="fa-regular fa-circle-xmark" style="color: #ff4abd;"></i> Not supported for Windows Server 2019 & 2012 in Core version.

The ongoing development aims to accommodate the Core and Nano versions of Windows Server. The lack of support is currently not due to operating system constraints but likely relates to necessary graphics DLLs used by the Chromium rendering engine, which are absent in trimmed versions of Windows Server. Following the achievement of full compatibility with Windows Server Core, strides towards supporting Windows Nano Server will commence.

[Addressing Issues with System.Drawing on Windows Nano Server](https://ironpdf.com/troubleshooting/libcef-dll-203/)

### Windows Server Standard & DataCenter Differentiation

Referring to Microsoft's detailed comparison "[Comparison of Standard and Datacenter editions of Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison)," the DataCenter edition of Windows Server harbors all features of the Standard edition plus additional enhancements for storage solutions. IronPDF is operational on Windows Server DataCenter with the Desktop Experience.

## Specific Windows Installation Requirements

The core IronPDF NuGet package relies on [IronPDF.Native.Chrome.Windows Package](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/), which brings the necessary Chrome binaries for both x86 and x64 architectures.

- The [IronPDF NuGet Package](https://www.nuget.org/packages/IronPdf/) caters to both x86 and x64 architectures of Windows.

For application targeting specific runtime architectures, surplus directories under `/runtimes` that aren't in use (either x86 or x64) may be eliminated.

## Hardware Requirements

Using the Chromium engine, IronPDF renders HTML to PDF with the same precision as the Chrome printing feature. The necessary hardware specifications are configured predominantly to manage the workload of the Chromium engine:

- Minimum Requirements: 1 Core CPU & 1.75 GB of RAM
- Recommended Setup: At least 2 Core CPU & 8 GB of RAM