***Based on <https://ironpdf.com/examples/custom-pdf-paper-size/>***

Creating PDF documents that display well on various devices and print correctly is crucial. To achieve this, specifying the desired virtual and actual paper sizes for your PDFs is essential.

Below is an illustration of how to introduce custom paper sizes into your PDF initiatives using IronPDF.

IronPDF facilitates nearly 50 standard paper sizes, alongside an infinite variety of custom dimensions that can accommodate any requirements you might have for your PDF outputs. These sizes can be specified in inches or millimeters.

The `PdfPaperSize` enum class is utilized to set both the virtual paper size of the PDF and its corresponding actual paper size.

You can craft PDFs of tailored dimensions using the following methods:

- `Renderer.RenderingOptions.SetCustomPaperSizeInInches`
- `Renderer.RenderingOptions.SetCustomPaperSizeInMillimeters`

There is also the `Renderer.RenderingOptions.PaperSize` method, which lets you use a custom preset size with precision up to 1 micron.

For further insights into how to leverage the custom paper size features and other sophisticated functionalities from IronPDF, check out the [IronPDF Documentation](https://ironpdf.com/docs/).

If you're keen on exploring additional robust libraries from Iron Software, like IronBarcode for generating and scanning barcodes, or IronOCR for optical character recognition, you can visit the [Iron Software Product Page](https://ironsoftware.com/).