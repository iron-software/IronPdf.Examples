using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section5
    {
        public void Run()
        {
            renderer.RenderingOptions.EnableJavaScript = true;
            renderer.RenderingOptions.WaitFor.RenderDelay(500); // milliseconds
        }
    }
}