using IronPdf;
namespace IronPdf.Examples.HowTo.Waitfor
{
    public static class Section3
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render after 3000ms
            renderer.RenderingOptions.WaitFor.RenderDelay(3000);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
        }
    }
}