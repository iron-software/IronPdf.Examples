using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section2
    {
        public void Run()
        {
            // Instantiate renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Create header and add to rendering options
            renderer.RenderingOptions.TextHeader = new TextHeaderFooter
            {
                CenterText = "This is the header!",
            };
            
            
            // Create footer and add to rendering options
            renderer.RenderingOptions.TextFooter = new TextHeaderFooter
            {
                CenterText = "This is the footer!",
            };
            
            // Render PDF with header and footer
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            pdf.SaveAs("renderWithTextHeaderFooter.pdf");
        }
    }
}