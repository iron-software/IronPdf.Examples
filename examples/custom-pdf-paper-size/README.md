***Based on <https://ironpdf.com/examples/custom-pdf-paper-size/>***

When preparing your PDF documents using IronPDF, it's important to ensure they display and print correctly. This involves specifying both the virtual and the real-world paper sizes for your document.

Here we illustrate how to incorporate custom paper sizes into your PDF initiatives.

IronPDF offers a comprehensive array of nearly 50 predefined paper sizes plus an infinite number of customizable options, ensuring there's a perfect fit for any requirement or special use case for your PDFs. These sizes can be specified in either inches or millimeters.

The `PdfPaperSize` enumeration is used to set the desired virtual and corresponding real-world paper sizes for your PDF.

To create PDFs with a specific custom size, you may utilize one of these methods depending on the measurement units:

- `Renderer.RenderingOptions.SetCustomPaperSizeInInches`
- `Renderer.RenderingOptions.SetCustomPaperSizeInMillimeters`

Alternatively, for pre-configured sizes with micron-level precision, you can use `Renderer.RenderingOptions.PaperSize`.

For further insights into how to harness the capabilities of custom paper sizes in IronPDF, as well as to explore other sophisticated features, please consult the [IronPDF Documentation](https://ironpdf.com/docs/).

[Discover more about Custom PDF Paper Sizes with IronPDF](https://ironpdf.com/how-to/custom-paper-size/)