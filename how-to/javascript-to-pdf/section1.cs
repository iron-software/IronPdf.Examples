using IronPdf;
namespace IronPdf.Examples.HowTo.JavascriptToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            string htmlWithJavaScript = @"<h1>This is HTML</h1>
            <script>
                document.write('<h1>This is JavaScript</h1>');
                window.ironpdf.notifyRender();
            </script>";
            
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Enable JavaScript
            renderer.RenderingOptions.EnableJavaScript = true;
            // Set waitFor for JavaScript
            renderer.RenderingOptions.WaitFor.JavaScript(500);
            
            // Render HTML contains JavaScript
            var pdfJavaScript = renderer.RenderHtmlAsPdf(htmlWithJavaScript);
            
            // Export PDF
            pdfJavaScript.SaveAs("javascriptHtml.pdf");
        }
    }
}