using System.IO;
using IronPdf;
namespace ironpdf.TableOfContents
{
    public class Section2
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
                CustomCssUrl = "./custom.css"
            };
            
            // Read HTML text from file
            string html = File.ReadAllText("tableOfContent.html");
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            pdf.SaveAs("tableOfContents.pdf");
        }
    }
}