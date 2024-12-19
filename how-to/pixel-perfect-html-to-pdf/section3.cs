using IronPdf;
namespace IronPdf.Examples.HowTo.PixelPerfectHtmlToPdf
{
    public static class Section3
    {
        public static void Run()
        {
            // Example of setting Timeout and RenderDelay options
            renderer.RenderingOptions.Timeout = 90; // seconds (default is 60)
            renderer.RenderingOptions.WaitFor.RenderDelay(30000); // milliseconds
        }
    }
}