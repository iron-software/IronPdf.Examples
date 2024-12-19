using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.TableOfContents
{
    public static class Section1
    {
        public static void Run()
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