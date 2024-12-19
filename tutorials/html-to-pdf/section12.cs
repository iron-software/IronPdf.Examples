using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section12
    {
        public static void Run()
        {
            renderer.RenderingOptions.MarginTop = 50; // millimeters
            renderer.RenderingOptions.MarginBottom = 50; // millimeters
        }
    }
}