using IronPdf;
namespace IronPdf.Examples.HowTo.Waitfor
{
    public static class Section4
    {
        public static void Run()
        {
            string html = @"<!DOCTYPE html>
            <html>
            <body>
            <h1>Testing</h1>
            <script type='text/javascript'>
            
            // Set delay
            setTimeout(function() {
                window.ironpdf.notifyRender();
            }, 1000);
            
            </script>
            </body>
            </html>";
            
            ChromePdfRenderOptions renderingOptions = new ChromePdfRenderOptions();
            
            // Set rendering to wait for the notifyRender function
            renderingOptions.WaitFor.JavaScript(5000);
            
            PdfDocument pdf = ChromePdfRenderer.StaticRenderHtmlAsPdf(html, renderingOptions);
        }
    }
}