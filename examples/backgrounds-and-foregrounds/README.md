***Based on <https://ironpdf.com/examples/backgrounds-and-foregrounds/>***

When crafting and designing PDF documents with IronPDF, you might consider implementing a specific design style consistently across your documents. To achieve this, IronPDF lets you superimpose one PDF document onto another, either as a backdrop or a foreground layer. This functionality proves invaluable for maintaining uniformity in document appearance and for template creation.

Here’s a guide on integrating a PDF into another as either a background or foreground.

This is accomplished in C# by creating or importing a multi-page PDF and treating it as an `IronPdf.PdfDocument` instance.

To introduce a background, utilize the `PdfDocument.AddBackgroundPdf` method. Comprehensive guidance on how to embed backgrounds can be found in the [IronPDF PdfDocument background documentation](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_AddBackgroundPdf_IronPdf_PdfDocument_System_Int32_). This documentation outlines various methods and their specific applications, facilitating the addition of a background from another PDF to each page of your current document.

In addition to backgrounds, you can apply what are termed "Overlays" or foregrounds using the `PdfDocument.AddForegroundOverlayPdfToPage` method. For an in-depth exploration of how overlays are implemented, refer to the [IronPDF PdfDocument overlay documentation](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html). This will give you a clear understanding of the different methods available for foreground insertion.