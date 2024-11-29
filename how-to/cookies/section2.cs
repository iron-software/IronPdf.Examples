using System.Collections.Generic;
using IronPdf;
namespace ironpdf.Cookies
{
    public class Section2
    {
        public void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            Dictionary<string, string> customCookies = new Dictionary<string, string>();
            
            // Apply custom cookies
            renderer.RenderingOptions.CustomCookies = customCookies;
            
            var uri = new Uri("https://localhost:44362/invoice");
            PdfDocument pdf = renderer.RenderUrlAsPdf(uri);
        }
    }
}