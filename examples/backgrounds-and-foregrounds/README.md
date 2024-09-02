When using IronPDF to create and render PDF documents, you may sometimes need to apply a consistent design element or template across multiple pages or documents. This can be efficiently done by utilizing an existing PDF as the background or foreground for another PDF file.

The following example demonstrates how to apply a PDF document as the background or foreground for a new PDF document:

In C#, this can be achieved by initiating or loading a multi-page PDF into an `IronPdf.PdfDocument` object.

For background inclusion, use the method `PdfDocument.AddBackgroundPdf`. The `IronPdf.PdfDocument` class provides various methods and overrides for inserting backgrounds. This function will append a pre-existing PDF page as a background to each page in your target PDF.

For adding foregrounds, often referred to as "Overlays," utilize the method `PdfDocument.AddForegroundOverlayPdfToPage`. Similar to backgrounds, the `IronPdf.PdfDocument` documentation details various methods and overrides for foreground insertion.