> Full guide: [Razor to PDF blazor server](https://ironpdf.com/examples/razor-to-pdf-blazor-server/)

This example illustrates the process of converting Razor components into PDFs.

The IronPdf.Extensions.Blazor package extends the capabilities of the base IronPdf library. To transform content from a Razor component into a PDF format, it is essential to implement both IronPdf.Extensions.Blazor and the original IronPdf libraries.

In the provided code snippet, we have already defined a model named **PersonInfo**. Within the `OnInitializedAsync` method, we populate a **persons** List with several new **PersonInfo** objects. We also map this list to the string identifier "persons" in the **Parameters** dictionary.

For the PDF conversion, we utilize the `PrintToPdf` method where the **ChromePdfRenderer** class is initiated. The `RenderRazorComponentToPdf` function is employed here to perform the conversion of the Razor component into a PDF by passing the **Parameters** dictionary for rendering.

[Discover how to convert Razor Components to PDF in Blazor Server](https://ironpdf.com/how-to/razor-to-pdf-blazor-server/).