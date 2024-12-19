***Based on <https://ironpdf.com/examples/backgrounds-and-foregrounds/>***

When developing PDF documents with IronPDF, you might find the need to utilize a particular background and foreground to ensure design integrity and ease of templating. For such requirements, IronPDF allows the use of an existing or newly generated PDF as the backdrop or overlay for another PDF document.

This guide will outline how to employ a PDF document as a background or foreground for another PDF using IronPDF.

In C#, this functionality is facilitated by initializing a `IronPdf.PdfDocument` object that either loads or creates a PDF with multiple pages.

To insert backgrounds, employ the method `PdfDocument.AddBackgroundPdf`. More comprehensive details on this and other background placement techniques can be found in the [IronPDF.PdfDocument background documentation](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_AddBackgroundPdf_IronPdf_PdfDocument_System_Int32_). This method allows you to add a background to every page of your current PDF, with the background being sourced from a page in another PDF.

For adding foregrounds, or "Overlays," use the method `PdfDocument.AddForegroundOverlayPdfToPage`. Extensive information about different methods of adding overlays can be accessed via the [IronPDF.PdfDocument overlay documentation](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html).