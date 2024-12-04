using IronPdf;
namespace ironpdf.Waitfor
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render as soon as the page is loaded
            renderer.RenderingOptions.WaitFor.PageLoad();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
        }
    }
}