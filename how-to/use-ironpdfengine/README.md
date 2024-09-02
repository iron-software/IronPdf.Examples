# Utilizing IronPdfEngine

IronPdfEngine is a standalone gRPC server aimed at supporting various operations with IronPDF such as the creation, modification, and reading of PDF documents. Developed as an independent C# .NET application, IronPdfEngine operates autonomously and does not require the .NET runtime for its execution.

## IronPdf .NET's Relationship with IronPdfEngine

IronPdf .NET is fully operational without the integration of IronPdfEngine. IronPdfEngine serves as an optional enhancement for utilizing IronPdf functionalities. Typically, IronPdf for .NET functions without the need for IronPdfEngine.

IronPdf for .NET and IronPdfEngine are version-dependent, meaning a particular version of IronPdf for .NET must pair with the corresponding version of IronPdfEngine. For instance, IronPdf version 2024.2.2 would necessitate IronPdfEngine 2024.2.2.

### Implementing IronPdf .NET with a Remote IronPdfEngine

To utilize IronPdf for .NET alongside a remote IronPdfEngine, the `IronPdf.slim` package from NuGet is required. If you are incorporating `IronPdf` or `IronPdf.Linux` in your project, opting for `IronPdf.slim` can help in minimizing the application size.

Assume your IronPdfEngine is remotely hosted on `123.456.7.8:33350`.

To set up the IronPdfEngine remotely, follow the directions provided in "[How to Pull and Run IronPdfEngine](https://ironpdf.com/how-to/pull-run-ironpdfengine/)."

Proceed by installing IronPdf via NuGet:
```shell
PM> Install-Package IronPdf
```

Once you have installed `IronPdf.slim`, you’ll need to configure the IronPdf to recognize where IronPdfEngine is located (ensure the specified address isn’t blocked by a firewall). Implement the following code early in your application (or right before using any IronPdf features):

```csharp
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

With this setup, your application will successfully connect to the Remote IronPdfEngine, enabling enhanced PDF handling capabilities.