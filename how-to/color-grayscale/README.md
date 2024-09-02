# Creating Grayscale PDFs

A grayscale PDF is a PDF file where all content—images, texts, and graphics—are rendered in shades of gray rather than the full spectrum of colors.

IronPDF provides an effective feature that allows the creation of PDF documents in grayscale. This is especially useful when considering the cost-effectiveness of mass printing and enhancing readability, especially when the original content contains bright or vibrant colors. Grayscale PDFs also offer better compatibility across different devices, software, and platforms, leading to a more consistent viewing and printing experience.

***

***

## Example: Generating a Grayscale PDF

To create a grayscale PDF, simply adjust the `GrayScale` attribute of the `RenderingOptions` object to `true`.

Below, the example demonstrates how to enable the grayscale setting using a `ChromePdfRenderer`. This instance then renders a webpage into a PDF, extracts the first page, and saves it. Here’s how it works:

```cs
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Enable grayscale rendering
renderer.RenderingOptions.GrayScale = true;

// Render the URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironsoftware.com/");

// Extract the first page and save it
pdf.CopyPage(0).SaveAs("test-grayscale.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/color-grayscale/color-grayscale-grayscale-pdf.pdf#zoom=75" width="100%" height="500px">
</iframe>

Currently, activating the Grayscale option converts all text within the PDF into images, which means that text extraction methods like `ExtractAllImages` won't retrieve any text data.

Although this functionality is presently limited to PDF creation, future enhancements might include converting already existing PDFs into grayscale, bolstering its utility further.