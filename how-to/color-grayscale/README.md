# Generating PDFs in Grayscale Using IronPDF

***Based on <https://ironpdf.com/how-to/color-grayscale/>***


Grayscale PDFs are documents in which all the content is displayed in varying shades of gray, eliminating the use of full-spectrum color. This is particularly useful for cost-effective bulk printing and improving readability when original document colors are too intense. Grayscale PDFs also boast better compatibility across different devices and platforms, ensuring uniformity in both viewing and printing experiences.

***

***

<h3>Begin with IronPDF</h3>

----------------------------------

## Example: Creating a Grayscale PDF

To create a grayscale PDF, enable the **GrayScale** property under **RenderingOptions** by setting it to **true**.

The following example outlines how to implement this by using the `ChromePdfRenderer`. We'll enable the grayscale option, convert a URL to PDF, extract the first page, and save it:

```cs
using IronPdf;

// Create a new PDF renderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Enable grayscale by setting GrayScale to true
renderer.RenderingOptions.GrayScale = true;

// Render a URL to PDF in grayscale
PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironsoftware.com/");
// Extract and save the first page of the PDF
pdf.CopyPage(0).SaveAs("grayscale-output.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/color-grayscale/color-grayscale-grayscale-pdf.pdf#zoom=75" width="100%" height="500px">
</iframe>

As it stands, when a PDF is rendered in grayscale, all text within the PDF gets converted to images, making the `ExtractAllImages` method unable to extract textual content.

This feature is presently limited to PDF rendering only. Expansion of these capabilities to include conversion of pre-existing PDFs to grayscale would be a valuable enhancement.