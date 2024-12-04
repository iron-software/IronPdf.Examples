# Utilizing IronPdfEngine

***Based on <https://ironpdf.com/how-to/use-ironpdfengine/>***


IronPdfEngine is a dedicated gRPC server that facilitates various operations on PDFs such as creation, modification, and retrieval. It is developed as a standalone C# .NET application, enabling it to function autonomously without relying on the .NET runtime for its operation.

## Relationship Between IronPdf .NET and IronPdfEngine

IronPdf .NET can operate independently and does not mandatorily require IronPdfEngine. IronPdfEngine serves as an optional component for utilizing IronPdf functionalities. By default, IronPdf for .NET does not incorporate IronPdfEngine.

Compatibility between IronPdf for .NET and IronPdfEngine is version-specific; thus, simultaneous version alignment is essential. For instance, IronPdf 2024.2.2 will correspondingly utilize IronPdfEngine 2024.2.2.

### Integrating IronPdf .NET with Remote IronPdfEngine

To connect IronPdf for .NET with a remotely hosted IronPdfEngine, the `IronPdf.slim` NuGet package is the sole requirement. This package can also replace `IronPdf` or `IronPdf.Linux` if the goal is to minimize the application size.

Suppose the IronPdfEngine is hosted remotely at `123.456.7.8:33350`. For detailed steps on setting up IronPdfEngine remotely, visit the following guide: [Pull and Run IronPdfEngine](https://ironpdf.com/how-to/pull-run-ironpdfengine/).

You can begin by installing the required IronPdf package via NuGet with the following command:

```shell
PM> Install-Package IronPdf
```

Once `IronPdf.slim` is installed, configure the connection to the IronPdfEngine by ensuring the server address is reachable and not restricted by your firewall. Use the `IronPdf.GrpcLayer.IronPdfConnectionConfiguration` class to establish these settings. Integrate the following example into the commencement phase of your application or just before executing any IronPdf method:

```cs
// Establish connection to the IronPdfEngine
Installation.ConnectToIronPdfHost(
    IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
);
```

By incorporating the above configuration, your application will be able to interact with the Remote IronPdfEngine efficiently.