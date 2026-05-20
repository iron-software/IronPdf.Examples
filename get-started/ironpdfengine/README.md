# Leveraging IronPDF in Engine Mode

***Based on <https://ironpdf.com/get-started/ironpdfengine/>***


## Comparative Analysis: Native vs Engine Deployment

IronPDF functions can be quite resource-demanding, which sometimes necessitates remote operation. Although IronPDF can operate without the remote `IronPdfEngine`, configuring it as a remote service is an effective strategy for circumventing compatibility issues with Google Chrome on older OS and mobile setups.

### Initiating with IronPDF

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

-------------------------------

## Coding Differences with Engine Configuration

For those opting for the Engine setup, it's advisable to install the `IronPdf.Slim` from NuGet. This version contains only essential components, as the full suite included in the standard `IronPdf` package is managed by the Engine, eliminating unnecessary bulk.

```shell
:InstallCmd Install-Package IronPdf.Slim
```

Once `IronPdf.Slim` is installed, the next step involves setting up the engine connection. This is done by specifying the address of your IronPdfEngine instance in your application's startup configuration or before any IronPDF functionalities are utilized.

### Critical Configuration Line in C#

Suppose the IronPdfEngine is hosted remotely at `123.456.7.8:33350`:

```csharp
// Set up a connection to the IronPdfEngine located remotely
// Replace the IP and port with those of your server
Installation.ConnectToIronPdfHost(
    IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
);

// Other necessary application code
```

## Understanding IronPdfEngine Operations

The `IronPdfEngine` is a containerized, server-side solution which facilitates a wide range of PDF tasks including creation, modification, and extraction, leveraging the gRPC communication protocol. Designed as a standalone C# .NET application, it does not depend on the .NET runtime, allowing seamless operation. We manage the gRPC linkage to ensure you can concentrate solely on programming.

For an introductory guide on running IronPDF in a standalone container mode, refer to this [tutorial](https://ironpdf.com/get-started/ironpdfengine-docker/).

## Additional Insights into IronPdfEngine

`IronPdf .NET` can function independently without the `IronPdfEngine`, though integrating it is a viable option. Each release of `IronPdf for .NET` is aligned with a corresponding `IronPdfEngine` version, ensuring compatibility is maintained, with no support for cross-version interoperability.

### Deploying IronPdf .NET with External IronPdfEngine

The streamlined `IronPdf.slim` package from NuGet suffices when using IronPDF with a remote engine. Whether you're deploying `IronPdf` or `IronPdf.Linux`, opting for `IronPdf.slim` can significantly reduce the footprint of your application.

Assuming remote access to IronPdfEngine at `123.456.7.8:33350`:

```shell
:InstallCmd Install-Package IronPdf.Slim
```

Post-installation, connection settings to the IronPdfEngine need to be configured using the `IronPdfConnectionConfiguration` class. Implement this configuration early in your application or right before utilizing any IronPdf features.

```csharp
// Establish a remote connection to the IronPdfEngine
Installation.ConnectToIronPdfHost(
    IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
);
```

With these steps, your application seamlessly integrates with the remote IronPdfEngine.

<hr>

## Constraints of IronPdfEngine

- IronPdfEngine currently does not support scaling horizontally (load balancing among multiple instances) as it processes PDFs in server memory and utilizes `PdfDocumentId` for server-client exchanges, enhancing speed and reducing bandwidth.
- For successful remote operation of the IronPdfEngine Docker, ensure accessibility of its port.
- IronPdfEngine Docker, based on Linux x64 (Debian) and built with the ubuntu:22.04 images, might yield slightly different PDF outputs compared to local executions due to OS variations.
- Operationally, as the IronPdfEngine Docker is tailored for Linux, a Linux Containers daemon is necessary on non-Linux systems (use `Switch to Linux Containers` on Windows).
- The engine's binaries are platform-specific, crafted distinctively for each supported platform.
- Like its counterpart, IronPdfEngine rules out cross-version compatibility.