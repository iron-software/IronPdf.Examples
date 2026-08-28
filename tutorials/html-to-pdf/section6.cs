using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section6
    {
        public static void Run()
        {
            // Configure JavaScript rendering for dynamic HTML content to PDF
            var renderer = new ChromePdfRenderer();
            
            // Enable JavaScript execution during PDF generation
            renderer.RenderingOptions.EnableJavaScript = true;
            
            // WaitFor.RenderDelay is a method, not a property.
            renderer.RenderingOptions.WaitFor.RenderDelay(500); // milliseconds
        }
    }
}