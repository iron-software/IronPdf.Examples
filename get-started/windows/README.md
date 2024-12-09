# Utilizing IronPDF for .NET on Windows Platforms

***Based on <https://ironpdf.com/get-started/windows/>***


IronPDF is fully compatible with Windows 10, 11, and various Windows Server editions for .NET versions 8, 7, 6, Core, .NET Standard, and .NET Framework.

## Key Considerations for Windows Server

Support is extended to **Windows Server 2022 and 2016** for both Desktop Experience and Core installations, whereas **Windows Server 2019 and 2012 are supported only in their Desktop Experience configurations**.

**Windows Server 2022 & 2016**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Available with a graphical user interface ("Desktop experience").
- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Available in a command-line-only environment ("Core").

**Windows Server 2019 & 2012**

- <i class="fa-regular fa-circle-check" style="color: #63E6BE;"></i> Supported with a graphical user interface ("Desktop experience").
- <i class="fa-regular fa-circle-xmark" style="color: #ff4abd;"></i> Not supported in a command-line-only environment ("Core").

Our commitment to expand support for the Core and Nano versions of Windows Server is ongoing. The challenge with the operating system does not stem from its architecture. It mainly relates to the absence of media/graphics DLLs needed by Chromium for HTML to PDF rendering, which are only accessible in the Desktop version.

Additionally, we are considering support for the minimalistic Windows Nano Server once there's full compatibility with the Windows Server Core.

Note: System.Drawing is not supported in Windows Nano Server or Server Core for .Net6.
[Read More About libcef.dll Issues](https://ironpdf.com/troubleshooting/libcef-dll-203/)

### For Unsupported Windows Versions, Consider IronPDF's Engine Mode

**Differences Between Native & Engine Modes**  
IronPDF provides some advanced features which you might opt to execute remotely to circumvent Chrome compatibility challenges with older Windows or mobile platforms. Using IronPdfEngine remotely is optional but helpful for these cases.

**Coding Changes with Engine Usage**  
This adaptation facilitates using older Windows versions like Windows Server 2012.

For applications utilizing Engine mode, it's recommended to install the lighter `IronPdf.Slim` package. Use the following PowerShell command:

```powershell
PM> Install-Package IronPdf.Slim
```

Configure the connection settings post-installation by directing IronPDF to your remote IronPdfEngine instance. Insert this code at your application’s startup (or before using any IronPDF functionalities):

```csharp
// Configuring connection to a remote IronPdfEngine
// hosted at IP 123.456.7.8 on port 33350.
IronPdf.Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

### Windows Server Standard & DataCenter Editions

Referencing Microsoft's documentation for a "[Comparison of Standard and DataCenter editions of Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison)", both Standard and DataCenter variants are suitable for IronPDF, with DataCenter offering additional storage solutions and functionalities.

## Specifics on Windows Installation

The principal IronPdf NuGet package relies on [IronPdf.Native.Chrome.Windows](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/), which includes the required Chrome binaries for both x86 and x64 Windows architectures.

- The [IronPdf](https://www.nuget.org/packages/IronPdf/) package supports x86 and x46 Windows architectures.

For optimal resource use, you may remove unused /runtimes directories (either x86 or x64).

## Recommended Hardware Specifications

IronPDF leverages the Chromium engine to convert HTML into PDFs, matching the quality of Chrome's print feature. The hardware requirements are mainly to accommodate the demands of the Chromium engine:

- Minimum: 1 Core & 1.75 GB of RAM
- Recommended: 2 Cores & 8 GB of RAM or more