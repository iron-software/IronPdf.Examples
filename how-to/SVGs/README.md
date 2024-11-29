# Converting SVG to PDF in C&#35;

***Based on <https://ironpdf.com/how-to/SVGs/>***


IronPDF provides robust support for transforming SVG graphics into PDF documents using the "HTML to PDF" approach.

It's crucial to specify the **width** and/or **height** style attributes for the **img** element when incorporating an SVG. If not set, the SVG could render at zero size and fail to display in the final PDF.

## Example of SVG to PDF Conversion

While many browsers can handle SVGs that lack explicit sizes, the rendering engine used by IronPDF requires these dimensions to be set.

```cs
using IronPdf;
namespace ironpdf.SVGs
{
    public class SvgToPdfConverter
    {
        public void Execute()
        {
            // Define the HTML format with an embedded SVG image
            string htmlContent = "<img src='https://ironsoftware.com/img/svgs/new-banner-svg.svg' style='width:100px'>";
            
            // Create a new instance of the PDF renderer with Chrome engine
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            pdfRenderer.RenderingOptions.WaitFor.RenderDelay(1000); // Set render delay to 1000 milliseconds
            
            // Render the HTML content to a PDF document
            PdfDocument document = pdfRenderer.RenderHtmlAsPdf(htmlContent);
            document.SaveAs("ConvertedSvgToPdf.pdf");
        }
    }
}
```

### Viewing the Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/SVGs/svgToPdf.pdf" width="100%" height="300px">
</iframe>

In some cases, setting explicit width and height attributes directly on the SVG node can be beneficial. For further details, please view [SVG styling examples on CodePen](https://codepen.io/AmeliaBR/pen/MYbzaW).