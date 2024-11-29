using IronPdf;
namespace ironpdf.Waitfor
{
    public class Section10
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render unless there are at most 2 network activities for at least 500ms
            renderer.RenderingOptions.WaitFor.NetworkIdle2();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
        }
    }
}