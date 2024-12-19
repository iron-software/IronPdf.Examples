using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section5
    {
        public static void Run()
        {
            renderer.RenderingOptions.EnableJavaScript = true;
            renderer.RenderingOptions.WaitFor.RenderDelay(500); // milliseconds
        }
    }
}