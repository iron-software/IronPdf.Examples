***Based on <https://ironpdf.com/examples/razor-to-pdf-blazor-server/>***

This sample illustrates the process of transforming a Razor component into a PDF file.

The package `IronPdf.Extensions.Blazor` serves as an addition to the primary `IronPdf` library. To transfer the contents of a Razor component into a PDF format, it's essential to utilize both the `IronPdf.Extensions.Blazor` and the core `IronPdf` packages.

In the provided code snippet, a model known as `PersonInfo` is pre-established. During the execution of the `OnInitializedAsync` method, we populate the `persons` List with several new instances of `PersonInfo`. Subsequently, this `persons` List is linked to the key "persons" within the `Parameters` dictionary.

When calling the `PrintToPdf` method, we create an instance of the `ChromePdfRenderer` class. To perform the conversion of the Razor component into a PDF document, we utilize the `RenderRazorComponentToPdf` method. In this example, the `Parameters` dictionary is furnished to the method to successfully render the content.