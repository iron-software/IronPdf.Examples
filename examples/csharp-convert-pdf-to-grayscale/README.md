***Based on <https://ironpdf.com/examples/csharp-convert-pdf-to-grayscale/>***

When converting an HTML page to a PDF using IronPDF, you can customize the `ChromePdfRenderer` class's output options to tailor the PDF document according to your specifications. These adjustments include setting the paper size, DPI, headers and footers, and other browser configuration options unique to Chromium. Additionally, IronPDF provides the ability to set the PDF output to grayscale.

This example demonstrates how to configure your PDF document to appear in grayscale.

Switching your document to grayscale simplifies the color palette to only black and white, which is particularly beneficial when printing on monochrome printers. The `ChromePdfRenderer` class includes an option for grayscale output, transforming the PDF to black and white. It is important to note that the default setting for this is `false`. Therefore, to activate grayscale rendering, you must enable the grayscale settings manually.

For further information on IronPDF's features, as well as other tools from Iron Software like IronBarcode and IronOCR, feel free to visit the [IronPDF Website](https://ironpdf.com/) and browse through additional resources and documentation at [Iron Software's Official Site](https://ironsoftware.com/).