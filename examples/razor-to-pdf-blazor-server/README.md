The example below illustrates how to transform a Razor component into a PDF file.

Utilizing the `IronPdf.Extensions.Blazor` package, an add-on to the primary `IronPdf` library, you can convert the content of a Razor component into a PDF format. Both `IronPdf.Extensions.Blazor` and the main `IronPdf` packages must be installed for this operation.

In the provided code snippet, a model named `**PersonInfo**` is established. We populate multiple new `**PersonInfo**` instances into the `**persons**` list via the `OnInitializedAsync` method. Subsequently, this list is linked with the key "persons" in the `**Parameters**` dictionary.

Within the `PrintToPdf` method, the `**ChromePdfRenderer**` class is instantiated. To execute the conversion of the Razor component into a PDF, the `RenderRazorComponentToPdf` method is employed. Here, the `**Parameters**` dictionary is supplied to the method for processing.