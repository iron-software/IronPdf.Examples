using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section12
    {
        public void Run()
        {
            renderer.RenderingOptions.MarginTop = 50; // millimeters
            renderer.RenderingOptions.MarginBottom = 50; // millimeters
        }
    }
}