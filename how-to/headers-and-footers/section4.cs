using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section4
    {
        public void Run()
        {
            // Instantiate renderer and create PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            
            TextHeaderFooter header = new TextHeaderFooter
            {
                CenterText = "This is the header!",
            };
            
            TextHeaderFooter footer = new TextHeaderFooter
            {
                CenterText = "This is the footer!",
            };
            
            pdf.AddTextHeaders(header, 35, 30, 25); // Left Margin = 35, Right Margin  = 30, Top Margin = 25
            pdf.AddTextFooters(footer, 35, 30, 25); // Margin values are in mm
        }
    }
}