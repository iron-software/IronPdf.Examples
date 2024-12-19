using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.TableOfContents
{
    public static class Section2
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
                CustomCssUrl = "./custom.css"
            };
            
            // Read HTML text from file
            string html = File.ReadAllText("tableOfContent.html");
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            pdf.SaveAs("tableOfContents.pdf");
        }
    }
}