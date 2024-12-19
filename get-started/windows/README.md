# Operating IronPDF for .NET on Windows Platforms

***Based on <https://ironpdf.com/get-started/windows/>***


IronPDF is well-supported across various Windows versions including Windows 10, Windows 11, and several Windows Server editions suitable for .NET versions such as .NET 8, .NET 7, .NET 6, .NET Core, .NET Standard, and .NET Framework.

## Key Insights on Windows Server Compatibility

IronPDF ensures compatibility with **Windows Server 2022 and 2016**, available for both the Desktop Experience and Core configurations. However, **Windows Server 2019 and 2012** are supported exclusively in the Desktop Experience format.

**Compatibility Breakdown for Windows Server Versions:**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Full support for Windows Server 2022 & 2016 with GUI ("Desktop experience") and without GUI ("Core").
- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Supported Windows Server 2019 & 2012 with GUI ("Desktop experience").
- <i class="fa-regular fa-circle-xmark" style="color: #ff4abd;"></i> Not supported for Windows Server 2019 & 2012 non-GUI ("Core").

Please note that IronPDF versions from 2023.3.2 to 2024.2.2 are incompatible with Windows Server 2012.

Efforts are ongoing to extend support to Windows Server Core and Nano variations. The core challenge lies in the absence of certain media/graphics DLLs in these streamlined Windows versions, which are essential for Chromium's HTML to PDF rendering.

We anticipate supporting Windows Nano Server following the full integration of Windows Server Core.

### Regarding Unsupported Windows Versions

For Windows variants that do not natively support IronPDF, you can opt for IronPDF in Engine Mode to circumvent these limitations.

**Understanding Native & Engine Modes:**  
Engine Mode enables resource-intensive features to be executed remotely, eliminating compatibility issues with older Windows versions or mobile platforms without requiring the full IronPdf package.

**Coding with IronPDF in Engine Mode:**  
This setup permits the use of older Windows versions, including Windows Server 2012.

Instead of the full IronPDF package, it's advisable to install `IronPdf.Slim` to manage program overhead more effectively via the Engine mode.

```powershell
PM> Install-Package IronPdf.Slim
```

Upon installation, configure your application to connect with the remote IronPdfEngine service by inserting the following initialization code:

```csharp
// Pointing to a remote IronPdfEngine instance
// at the specified IP and port.
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

### Windows Server Standard vs. DataCenter

Based on Microsoft's "[Comparison of Standard and Datacenter editions of Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison)", the DataCenter edition encompasses all features of the Standard edition with added capabilities specifically for enhanced storage. IronPDF functions seamlessly within both Windows Server DataCenter and Standard Desktop Experiences.

## Specific Installation Steps for Windows

IronPDF depends on the [IronPdf.Native.Chrome.Windows](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/) package from NuGet, which supports the Chrome renderer in both x86 and x64 architectures.

- The [IronPdf](https://www.nuget.org/packages/IronPdf/) package is compatible with Windows x86 and x64 systems.

If only a single architecture is needed, the irrelevant /runtimes directory can be removed to streamline the installation.

## Hardware Requirements

Since IronPDF is based on the Chromium engine to transform HTML into PDFs, the hardware primarily supports the operation of this engine. 

- Minimum specification requires: 1 Core & 1.75 GB of RAM
- Recommended specification suggests: 2 Cores & 8 GB of RAM or more