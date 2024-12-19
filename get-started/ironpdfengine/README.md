# Use IronPDF with in-Engine Mode

***Based on <https://ironpdf.com/get-started/ironpdfengine/>***


## Comparing Native and Engine Configurations

With IronPDF, certain resource-intensive tasks can be operated remotely, enhancing performance. While IronPDF doesn't inherently demand the IronPdfEngine for operation, configuring IronPdfEngine as an external service is an effective solution to bypass compatibility concerns of Google Chrome on outdated operating systems and mobile platforms.

### Begin Using IronPDF

---

## Coding Differences with IronPDF Engine Mode

For those opting for the Engine configuration, it’s advisable to install the `IronPdf.Slim` package from NuGet instead of the bulkier full `IronPdf` package since the Engine configuration handles the load that is typically managed by the full package.

```powershell
PM> Install-Package IronPdf.Slim
```

Once `IronPdf.Slim` is installed, setting up the connection settings involves directing IronPDF to an IronPdfEngine instance. This adjustment should be made at the start of your application (or before employing any IronPDF functionalities):

### Required Configuration in Your C# Code

Assume your IronPdfEngine is hosted remotely at `123.456.7.8:33350`:
```csharp
// ... previous code ...

Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));

// ... following code ...
```

## IronPdfEngine Overview

IronPdfEngine is an encapsulated server geared towards handling numerous PDF operations, including creation, modification, and extraction, through the gRPC protocol. Engineered as a standalone C# .NET application, IronPdfEngine performs independently without the need for a .NET runtime. The gRPC connection management is streamlined by us, allowing you to concentrate on your application development.

## Additional Details on IronPdfEngine

It is important to note that IronPDF .NET does not mandate the use of IronPdfEngine, which serves as an optional enhancement. Importantly, each IronPDF release requires a corresponding version of IronPdfEngine due to compatibility protocols, ensuring synchronization between software versions, for instance, IronPDF 2024.2.2 with IronPdfEngine 2024.2.2.

### Utilizing IronPdf .NET with Remote IronPdfEngine

To integrate IronPDF with a remote IronPdfEngine, the `IronPdf.slim` NuGet package is essential. Should you have been employing `IronPdf` or `IronPdf.Linux`, switching to `IronPdf.slim` can significantly decrease the application size.

Assuming IronPdfEngine is hosted at `123.456.7.8:33350`, understand the operational specifics by reviewing the guide on ["How to Pull and Run IronPdfEngine"](https://www.ironpdf.com/how-to/pull-run-ironpdfengine/).

To install IronPDF, use the below NuGet command:
```shell
PM> Install-Package IronPdf
```

Post-installation of `IronPdf.slim`, simply configure the connection to the IronPdfEngine (ensuring the server address is not firewalled). Use the `IronPdfConnectionConfiguration` class to establish this setting right at the inception of your application or just prior to invoking any IronPDF methods.

```csharp
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

That’s it! This configuration connects your application to the Remote IronPdfEngine seamlessly!