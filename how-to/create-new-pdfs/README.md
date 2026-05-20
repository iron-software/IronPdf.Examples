# Creating New PDF Documents

***Based on <https://ironpdf.com/how-to/create-new-pdfs/>***


To start building a new PDF document from the ground up, one might use libraries such as IronPDF in C#. These tools provide developers the capability to specifically design the content, layout, and formatting, after which the file is saved in PDF format.

```cs
:title=Instantly start with a blank PDF!
new IronPdf.PdfDocument { DefaultPageSize = new IronPdf.PageSize(260,260) }.SaveAs("newBlankPDF.pdf");
```

## Example of Crafting a Blank PDF

Creating a PDF can be straightforward, involving only the specifications of its dimensions. By employing the `PdfDocument` constructor, you can initiate a new PDF, pristine and ready for further enhancements and applications.

### Demonstrative Code

```cs
using IronPdf;

PdfDocument pdf = new PdfDocument(260, 260);

pdf.SaveAs("newBlankPDF.pdf");
```

<hr>

## Loading PDF from a File

To modify or transform a PDF, it initially needs to be loaded into the `PdfDocument` object. This can be achieved using the `FromFile` method from the `PdfDocument` class. This method also supports importing PDFs from various sources like JSON, byte arrays, streams, or URLs.

### Code Sample

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("example.pdf");

pdf.SaveAs("altered.pdf");
```

<hr>

## Converting from Other Formats

Beyond the standard methods of obtaining a `PdfDocument`, there is the advanced option of converting other formats such as HTML, which includes comprehensive rendering of all associated components like JavaScript, images, links, and CSS using the Chrome engine. Conversions from other formats like images, RTF, Markdown, and XML are also supported.

Here’s an example demonstrating how to convert HTML to PDF with all styling preserved.

```cs
using IronPdf;

// Initialize Renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.PaperFit.UseResponsiveCssRendering(1800);
renderer.RenderingOptions.WaitFor.RenderDelay(5000);
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;

// Generate a PDF from web URL or local file
var pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Save to file or Stream
pdf.SaveAs("rendered.pdf");
```

The final PDF can be viewed in an embedded PDF viewer, which typically displays the output file in the iframe shown below.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/extendedLeftSide.pdf#view=fit" width="100%" height="400px">
</iframe>