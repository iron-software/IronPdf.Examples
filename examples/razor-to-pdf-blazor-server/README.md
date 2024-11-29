***Based on <https://ironpdf.com/examples/razor-to-pdf-blazor-server/>***

This sample illustrates how to convert a Razor component into a PDF document using IronPdf.

The package `IronPdf.Extensions.Blazor` complements the core `IronPdf` library. For transforming a Razor component's content page into a PDF, it's essential to have both `IronPdf.Extensions.Blazor` and `IronPdf` installed.

In the provided code snippet, a model named `PersonInfo` has been established. Within the `OnInitializedAsync` method, we populate the `persons` List with new instances of `PersonInfo`. These entries are then mapped to the key "persons" in the `Parameters` dictionary.

During the execution of the `PrintToPdf` method, we create an instance of the `ChromePdfRenderer` class. This class employs the `RenderRazorComponentToPdf` method to transform the Razor component into a PDF file. Here, the `Parameters` dictionary is supplied to the method to facilitate the rendering process.