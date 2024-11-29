***Based on <https://ironpdf.com/examples/custom-pdf-paper-size/>***

When working with IronPDF to create your PDF documents, it's essential to ensure they are optimally formatted for viewing or printing. This involves selecting the appropriate virtual and corresponding real-world paper sizes.

This tutorial demonstrates how you can implement custom paper sizes in your PDF projects with IronPDF.

IronPDF accommodates nearly 50 predefined paper sizes and also allows for the creation of countless custom sizes to accommodate any specific needs for your PDF documents. You can specify these dimensions in either inches or millimeters.

The `PdfPaperSize` enum is used to set the intended virtual and actual paper sizes for the PDF.

To define a custom paper size in your PDF, you might use any of the following methods:

- `Renderer.RenderingOptions.SetCustomPaperSizeInInches`
- `Renderer.RenderingOptions.SetCustomPaperSizeinMilimeters`

Alternatively, `Renderer.RenderingOptions.PaperSize` offers a preset custom paper size with precision up to 1 micron.

For comprehensive guidance on leveraging the custom paper size feature and other advanced functionalities in IronPDF, explore the [IronPDF Documentation](https://ironpdf.com/docs/).

If you are also interested in exploring other robust libraries from Iron Software, like IronBarcode for generating and scanning barcodes or IronOCR for optical character recognition, please visit the [Iron Software Product Page](https://ironsoftware.com/).