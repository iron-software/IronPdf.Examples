using IronPdf;
namespace ironpdf.RenderingOptions
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure rendering options
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                HtmlFragment = "<h1>Header Content</h1>"
            };
            renderer.RenderingOptions.SetCustomPaperSizeinMilimeters(150, 150);
            renderer.RenderingOptions.MarginTop = 0;
            
            // Markdown string
            string md = "This is some **bold** and *italic* text.";
            
            // Render from markdown string
            PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(md);
            
            // Save the PDF
            pdf.SaveAs("renderingOptions.pdf");
        }
    }
}