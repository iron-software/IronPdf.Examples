using IronPdf;
namespace IronPdf.Examples.HowTo.Ironpdf2021ChromeRenderingEngineEap
{
    public static class Section3
    {
        public static void Run()
        {
            // Example for rendering a pixel-perfect PDF from HTML
            var renderer = new IronPdf.ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            pdf.SaveAs("HelloWorld.pdf");
        }
    }
}