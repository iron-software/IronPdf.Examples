# Implementing IronPDF in Engine Mode

***Based on <https://ironpdf.com/get-started/ironpdfengine/>***


## Differences Between Native and Engine Implementations

IronPDF includes certain functions that are performance-intensive and may be beneficial to run remotely. Although it is not necessary to use IronPdfEngine to execute IronPDF, configuring IronPdfEngine as a remote service can be a strategic choice to circumvent compatibility issues with older operating systems and mobile platforms when using the native Chrome.

## Adjusting Your Code to Use IronPDF with Engine Mode
For those opting for the Engine mode, it's advisable to use the `IronPdf.Slim` package instead of the standard `IronPdf` package. This is because `IronPdf.Slim` includes just the essential components needed, and the Engine handles everything else. You can add `IronPdf.Slim` to your project via NuGet:

```powershell
PM> Install-Package IronPdf.Slim
```

Once `IronPdf.Slim` is installed, the next step is setting up your connection to the IronPdfEngine server. You should add this configuration at the beginning of your application or before any IronPDF specific operations are initiated:

### Necessary Configuration Code Snippet in C#

Assuming you have the IronPdfEngine running remotely at `123.456.7.8:33350`:
```csharp
// ... existing code ...

Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));

// ... subsequent code ...
```

## Overview of IronPdfEngine Functionality

IronPdfEngine is a self-contained server based on container technology tailored to handle IronPDF tasks, including PDF creation, editing, and reading. This server uses the gRPC protocol for operation and is built as an independent C# .NET application, freeing you from the need for .NET runtime during its operation. Our implementation takes care of the gRPC connectivity so you can concentrate on your development work.

## Additional Details about IronPdfEngine

It's important to note that IronPDF .NET does not mandate the use of IronPdfEngine; it remains an optional implementation. Usually, each IronPDF.NET version corresponds to a specific version of IronPdfEngine; cross-version support is not provided. For instance, IronPdf 2024.2.2 would align with IronPdfEngine 2024.2.2.

### Setting Up IronPDF.NET with a Remote IronPdfEngine

To utilize IronPDF for .NET with a Remote IronPdfEngine, the `IronPdf.slim` package suffices. If you're currently using `IronPdf` or `IronPdf.Linux`, consider switching to `IronPdf.slim` to reduce your application footprint.

To deploy IronPdfEngine remotely, please follow the instructions on "[How to Pull and Run IronPdfEngine](https://ironpdf.com/how-to/pull-run-ironpdfengine/)."

You can install `IronPdf.slim` via NuGet as shown:

```shell
PM> Install-Package IronPdf
```

After installation, simply configure IronPDF to connect with IronPdfEngine. Ensure that the server address is reachable and not obstructed by any firewall. Integrate the following code into the initial phase of your application, or right before you begin using any IronPDF methods:

```csharp
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

With this configuration, your application is all set to interact with the Remote IronPdfEngine!