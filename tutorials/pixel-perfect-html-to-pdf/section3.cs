using IronPdf;
namespace ironpdf.PixelPerfectHtmlToPdf
{
    public class Section3
    {
        public void Run()
        {
            // Example of setting Timeout and RenderDelay options
            renderer.RenderingOptions.Timeout = 90; // seconds (default is 60)
            renderer.RenderingOptions.WaitFor.RenderDelay(30000); // milliseconds
        }
    }
}