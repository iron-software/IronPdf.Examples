using System.IO;
using IronPdf;
namespace ironpdf.TableOfContents
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure render options
            renderer.RenderingOptions = new ChromePdfRenderOptions
            {
                // Enable table of content feature
                TableOfContents = TableOfContentsTypes.WithPageNumbers,
            };
            
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableOfContent.html");
            
            pdf.SaveAs("tableOfContents.pdf");
        }
    }
}