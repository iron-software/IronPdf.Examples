using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section6
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                HtmlFragment = @"<div style='background-color: #4285f4; color: white; padding: 15px; text-align: center;'>
                                <h1>Example header</h1> <br>
                                <p>Header content</p>
                                </div>",
                // Enable the dynamic height feature
                MaxHeight = HtmlHeaderFooter.FragmentHeight,
            };
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            pdf.SaveAs("dynamicHeaderSize.pdf");
        }
    }
}