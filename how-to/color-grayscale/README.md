# How to Create a Grayscale PDF

***Based on <https://ironpdf.com/how-to/color-grayscale/>***


A grayscale PDF is a document formatted in greyscale, which uses varying shades of gray and skips the colored spectrum entirely.

IronPDF supports the creation of grayscale PDF outputs from web content or HTML documents. Converting PDFs to grayscale is economically smart when doing large volume printings. Additionally, using grayscale can improve readability by reducing the glare of overly vivid colors, and it bolsters compatibility across different devices, software, and platforms, providing a uniform printing and viewing experience everywhere.

## Quickstart: Convert Color PDFs to Grayscale with IronPDF

Easily convert your colorful PDFs to grayscale using IronPDF by adjusting the `GrayScale` property in the `RenderingOptions`. This guide will walk you through the steps to quickly produce grayscale PDF documents, ensuring they look consistent across various platforms.

```cs
:title=Instant Grayscale Conversion
var pdfConverter = new IronPdf.ChromePdfRenderer();
pdfConverter.RenderingOptions.GrayScale = true;
var resultPdf = pdfConverter.RenderUrlAsPdf("https://example.com");
resultPdf.SaveAs("grayscale-output.pdf");
```

## Example of Producing a Grayscale PDF

To create a grayscale PDF, simply toggle the `GrayScale` property in the `RenderingOptions` to `true`.

The example below demonstrates activating the grayscale option by using a `ChromePdfRenderer` instance. It then proceeds to convert a specific URL to PDF, extracts the first page of the document, and saves it.

```csharp
using IronPdf;

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Activates grayscale rendering
pdfRenderer.RenderingOptions.GrayScale = true;

PdfDocument grayscalePdf = pdfRenderer.RenderUrlAsPdf("https://ironsoftware.com/");
grayscalePdf.CopyPage(0).SaveAs("example-grayscale.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/color-grayscale/color-grayscale-grayscale-pdf.pdf#zoom=75" width="100%" height="500px">
</iframe>

It's worth noting that in this grayscale mode, any text content is transformed into an image during the PDF rendering, making it impossible for the `ExtractAllImages` method to recognize or extract text.

For the moment, this grayscale feature is integrated specifically for PDF rendering from web sources or HTML. Looking forward, expanding this functionality to include converting existing PDF files to grayscale would enhance its utility.

Curious to explore further? Dive into more with our guide here: [Learn to Convert PDFs](https://ironpdf.com/tutorials/convert-pdf/).