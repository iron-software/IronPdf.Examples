using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section2
    {
        public void Run()
        {
            // Add header and footer to rendering options
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
            {
                CenterText = "{page} of {total-pages}"
            };
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
            };
            
            string html = @"
                <h1>Hello World!</h1>
            <div style='page-break-after: always;'/>
                <h1>2nd Page!</h1>";
            
            // Render new PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            pdf.SaveAs("applyPageNumberWithRenderingOptions.pdf");
        }
    }
}