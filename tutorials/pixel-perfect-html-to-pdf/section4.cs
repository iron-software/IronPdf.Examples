using IronPdf;
namespace IronPdf.Examples.Tutorial.PixelPerfectHtmlToPdf
{
    public static class Section4
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var renderer = new IronPdf.ChromePdfRenderer();

            // Example of setting Timeout and RenderDelay options
            renderer.RenderingOptions.Timeout = 90; // seconds (default is 60)
            renderer.RenderingOptions.WaitFor.RenderDelay(30000); // milliseconds
        }
    }
}