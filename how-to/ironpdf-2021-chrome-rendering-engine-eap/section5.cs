using IronPdf;
namespace IronPdf.Examples.HowTo.Ironpdf2021ChromeRenderingEngineEap
{
    public static class Section5
    {
        public static void Run()
        {
            // Example of using async rendering
            var renderer = new IronPdf.ChromePdfRenderer();
            var task = await renderer.RenderHtmlAsPdfAsync("<h1>Async PDF</h1>");
            task.SaveAs("AsyncHelloWorld.pdf");
        }
    }
}