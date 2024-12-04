using IronPdf;
namespace ironpdf.Waitfor
{
    public class Section9
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render unless there has been no network activity for at least 500ms
            renderer.RenderingOptions.WaitFor.NetworkIdle0();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
        }
    }
}