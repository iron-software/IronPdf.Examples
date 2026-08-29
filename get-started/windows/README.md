# Utilizing IronPDF for .NET on Windows Platforms

> Full guide: [Utilizing IronPDF for .NET on Windows Platforms](https://ironpdf.com/get-started/windows/)


IronPDF is fully compatible with Windows 10, 11, and Windows Server across .NET 8, 7, 6, Core, .NET Standard, and .NET Framework versions.

## Key Information on Windows Server Compatibility

**Supported Windows Server Versions:**

- **Windows Server 2022 and 2016:**
  - Available in both Desktop Experience and Core setups.
- **Windows Server 2019 and 2012:**
  - Supported only in the Desktop Experience configuration.

Note: IronPDF versions ranging from 2023.3.2 to 2024.2.2 do not support Windows Server 2012.

Efforts are ongoing to provide support for both Core and Nano versions of Windows Server, with challenges primarily caused by required media/graphics DLLs from Chromium’s Chrome Renderer. These DLLs are not present in minimal server versions, impacting HTML to PDF rendering capabilities.

Full support for Windows Server Core will be the precursor to support for Windows Nano Server.

Windows Nano Server and Server Core on .NET 6 lack support for `System.Drawing`.  
For more insights, visit [our troubleshooting page](https://ironpdf.com/troubleshooting/libcef-dll-203/).

### Alternatives for Unsupported Windows Versions: IronPDF Engine Mode

#### **Distinguishing Between Native and Engine Modes**

IronPDF offers performance-intensive functions which could instead be operated remotely via IronPdfEngine, thereby circumventing platform-specific compatibility issues on outdated OS versions or mobile environments. This remote operation is optional and independent of the native IronPDF functionality.

#### **Coding with IronPDF in Engine Mode**

This alternative enables the use of systems like Windows Server 2012 that are otherwise unsupported.

For minimal package overhead, switch to `IronPdf.Slim` from NuGet when using Engine Mode:

```shell
# Install the IronPdf.Slim package using the Package Manager Console

Install-Package IronPdf.Slim
```

Then, configure your application to connect to your remote IronPdfEngine at startup or before invoking any IronPDF methods:

```csharp
// Connect your application to the remote IronPdfEngine server
// Update with the actual server IP and port
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

### Compatibility with Windows Server Standard & DataCenter

Comparing the [Standard and DataCenter editions for Windows Server 2016](https://learn.microsoft.com/en-us/windows-server/get-started/editions-comparison-windows-server-2016?tabs=full-comparison), it's evident that DataCenter editions incorporate all features of the Standard version plus additional storage enhancements, making IronPDF compatible with both.

## Setting Up IronPDF on Windows

**Via NuGet**

The primary IronPdf package relies on [IronPdf.Native.Chrome.Windows](https://www.nuget.org/packages/IronPdf.Native.Chrome.Windows/), providing the Chrome binary for both x86 and x64 systems. If a specific runtime is targeted, unnecessary /runtimes folders could be removed.

**Direct DLL Access**

For projects requiring offline capability:

- [Download IronPdf.dll here](https://ironpdf.com/packages/IronPdf.zip)

**Installer Availability**

For those preferring a more graphical setup via Visual Studio:

- [Get the IronPdf Installer](https://ironpdf.com/packages/IronPdfInstaller.zip)

## Recommended Hardware Specifications

The usage of the Chromium engine, known for its precise rendering capabilities mirroring Chrome’s print feature, dictates the hardware requirement primacy:

- **Minimum**: 1 Core & 1.75 GB of RAM
- **Recommended**: 2 Cores & 8 GB of RAM or more