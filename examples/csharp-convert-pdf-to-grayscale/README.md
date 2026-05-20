***Based on <https://ironpdf.com/examples/csharp-convert-pdf-to-grayscale/>***

When converting an HTML page to a PDF using IronPDF, the `ChromePdfRenderer` class allows you to tailor the output through various options. These include setting the paper size, DPI, and integrating headers and footers, alongside various other options specific to Chromium browsers. Additionally, there's a feature that allows you to set your PDFs to be rendered in grayscale.

Below is a guide on how to configure your PDF document to be displayed in grayscale using IronPDF.

Transforming your document into grayscale dims down the colors to black and white, which simplifies the process of printing on monochrome printers. The grayscale setting within the `ChromePdfRenderer` class lets you produce a PDF in black and white. Note, this setting is not enabled by default; you will need to adjust the grayscale settings manually.

Here’s how you can render an HTML document as a grayscale PDF using the IronPDF library:

1. **Initialization of ChromePdfRenderer**: Start by creating a new instance of the `ChromePdfRenderer`. This class is equipped with functionalities to convert HTML content directly into PDFs.

2. **Adjust Rendering Settings**: Access the `RenderingOptions` attribute of the renderer to customize the PDF output. Use the `SetPaperSize` function to designate the document size to A4. Set the `RenderInGrayscale` attribute to `true`, enabling grayscale mode in the PDF. Remember, by default, PDFs render in full color unless otherwise specified.

3. **HTML to PDF Conversion**: Execute the `RenderHtmlAsPdf` function on the `Renderer` object by passing through a basic HTML string. This function will transform the HTML into a PDF file.

4. **Saving the PDF**: Utilize the `SaveAs` method to store the PDF you've rendered into a file named "GrayscalePDF.pdf" on your storage.

For further information about IronPDF and other tools like IronBarcode and IronOCR from Iron Software, feel free to visit the [IronPDF Website](https://ironpdf.com/) where you can find additional resources and documentation at [Iron Software's Official Site](https://ironsoftware.com/).

[Discover more about converting PDFs to grayscale via the detailed guide.](https://ironpdf.com/how-to/color-grayscale/)