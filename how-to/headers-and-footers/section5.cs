using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section5
    {
        public void Run()
        {
            // Instantiate renderer and create PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            TextHeaderFooter header = new TextHeaderFooter
            {
                CenterText = "This is the header!",
            };
            
            TextHeaderFooter footer = new TextHeaderFooter
            {
                CenterText = "This is the footer!",
            };
            
            // Margin values are in mm
            renderer.RenderingOptions.MarginRight = 30;
            renderer.RenderingOptions.MarginLeft = 30;
            renderer.RenderingOptions.MarginTop = 25;
            renderer.RenderingOptions.MarginBottom = 25;
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
            
            // Add header and footer to renderer
            renderer.RenderingOptions.TextHeader = header;
            renderer.RenderingOptions.TextFooter = footer;
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
        }
    }
}