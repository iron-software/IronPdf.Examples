# IronPDF Compatibility with Windows on .NET Environments

IronPDF is fully compatible with Windows 10, 11, and various Windows Server editions across .NET versions including 8, 7, 6, Core, Standard, and Framework.

## Compatibility with Windows Server Editions

IronPDF ensures robust support for **Windows Server 2022 and 2016** in both Desktop Experience and Core configurations, while **Windows Server 2019 and 2012** are supported only in the Desktop Experience setup.

**Windows Server 2022 & 2016 Support:**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Available for Windows Server 2022 & 2016 Desktop Experience version
- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Also supports Windows Server 2022 & 2016 in a command-line only (Core) environment

**Windows Server 2019 & 2012 Support:**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Supported on Windows Server 2019 & 2012 Desktop Experience
- <i class="fa-regular fa-circle-xmark" style="color: #ff4abd;"></i> Does not support the Core version for Windows Server 2019 & 2012

Our development team is actively working towards extending support to the Core and Nano versions of Windows Server. The absence of certain media/graphics DLLs required by Chromium (Chrome Renderer) for HTML to PDF conversion in these minimalist server environments is the primary limitation, not the OS architecture itself.

Once comprehensive support for Windows Server Core is established, exploring compatibility with Windows Nano Server will be our next milestone.

It's important to note that Windows Nano Server and Server Core in .NET 6 currently do not support `System.Drawing`.
[Learn more about this issue](https://ironpdf.com/troubleshooting/libcef-dll-203/)

### Windows Server Standard & DataCenter

According to Microsoft's [comparison of Standard and Datacenter editions of Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison), the DataCenter version includes extra features primarily related to storage enhancements over the Standard version. IronPDF is operational on both the Desktop Experience version of Windows Server DataCenter as well as the Standard edition.

## Installation Specifics for Windows

IronPDF's installation depends on the `IronPdf.Native.Chrome.Windows` NuGet package, available [here](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/), which contains the necessary Chrome binaries for both x86 and x64 architectures.

- The `IronPdf` package is [available here](https://www.nuget.org/packages/IronPdf/) and supports both x86 and x64 architectures on Windows.

Developers can optimize their installations by removing the unused /runtimes folder (either x86 or x64), depending on their target runtime environment.

## Hardware Requirements

IronPDF uses the Chromium engine to convert HTML to PDF, requiring substantial computing resources similar to Chrome's print functionality.

- Minimum Requirements: 1 CPU Core & 1.75 GB of RAM.
- Recommended Specifications: 2 CPU Cores & 8 GB of RAM or more.