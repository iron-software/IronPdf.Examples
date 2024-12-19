# Utilizing IronPdfEngine for Enhanced PDF Operations

***Based on <https://ironpdf.com/how-to/use-ironpdfengine/>***


IronPdfEngine is structured as a gRPC server to support various functions of IronPDF, which range from generating and modifying to processing PDF documents. Engineered as an autonomous C# .NET application, IronPdfEngine operates on its own, avoiding reliance on the .NET runtime during its operations.

<h3>Getting Started with IronPDF</h3>

-----

## IronPdf .NET and IronPdfEngine Integration

IronPdf .NET does not depend on IronPdfEngine for functionality. It’s important to note that the use of IronPdfEngine is purely optional. IronPdf for .NET, by default, functions exclusively without the implementation of IronPdfEngine.

For seamless operation, each iteration of IronPdf for .NET is tied to a corresponding version of IronPdfEngine, with no allowance for cross-version interactions. For instance, IronPdf version 2024.2.2 will specifically require IronPdfEngine version 2024.2.2 for compatibility.

### Implementing IronPdf .NET with Remote IronPdfEngine

To employ IronPdf for .NET alongside a remote IronPdfEngine, the `IronPdf.slim` NuGet package suffices. If you currently use `IronPdf` or `IronPdf.Linux`, consider switching to `IronPdf.slim` to optimize the footprint of your application.

In scenarios where IronPdfEngine is hosted remotely, for example at `123.456.7.8:33350`.

For details on executing IronPdfEngine in a remote context, please consult the guide ["Deploy and Operate IronPdfEngine"](https://ironpdf.com/how-to/pull-run-ironpdfengine/).

To install IronPdf, use the following NuGet command:

```shell
PM> Install-Package IronPdf
```

Once you've installed `IronPdf.slim`, the next step is to configure the location of the IronPdfEngine (ensure the address is reachable and not obstructed by any firewall). Utilize the **IronPdfConnectionConfiguration** class to set up these specifics. Include the subsequent code at the beginning of your application or just before utilizing any IronPdf methods:

```cs
Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
```

With this configuration in place, your application is now linked to the Remote IronPdfEngine, enhancing your document processing capabilities!