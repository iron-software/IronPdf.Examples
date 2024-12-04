# Generating Grayscale PDFs with IronPDF

***Based on <https://ironpdf.com/how-to/color-grayscale/>***


A grayscale PDF contains all visual elements in shades of gray, rather than in multiple colors, making it ideal for certain types of document processing.

IronPDF provides capabilities for creating PDFs in grayscale, which is particularly useful for cost-effective printing in large batches. Grayscale rendering also improves readability when the original colors are too intense or distracting. Moreover, grayscale PDFs ensure greater compatibility with various devices and platforms, offering a consistent viewing and printing experience across different environments.

***

***

## Example: Generating a Grayscale PDF

You can create a grayscale PDF by setting the `GrayScale` property in the `RenderingOptions` to `true`.

Below is a practical example, where we use the `ChromePdfRenderer` to render a grayscale PDF from a webpage. This example demonstrates setting the grayscale option, rendering a URL as a PDF, and saving only the first page of that PDF.

```cs
using IronPdf;
namespace ironpdf.ColorGrayscale
{
    public class GenerateGrayscalePdf
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Enable grayscale rendering
            renderer.RenderingOptions.GrayScale = true;
            
            PdfDocument document = renderer.RenderUrlAsPdf("https://ironsoftware.com/");
            document.CopyPage(0).SaveAs("grayscale-output.pdf");
        }
    }
}
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/color-grayscale/color-grayscale-grayscale-pdf.pdf#zoom=75" width="100%" height="500px">
</iframe>

Currently, using the Grayscale feature converts all text within the PDF to images, therefore, methods like `ExtractAllImages` will not retrieve any textual content.

The capability to convert existing PDF documents to grayscale would be a valuable addition to future versions of the software, extending the utility of this feature.