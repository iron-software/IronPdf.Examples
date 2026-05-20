using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.HttpRequestHeader
{
    public static class Section2
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.HttpRequestHeaders = new Dictionary<string, string>
            {
                { "Authorization", "Bearer test-token-123" }
            };
            
            // Render PDF from authenticated page
            var pdf = renderer.RenderUrlAsPdf("https://httpbin.org/bearer");
            pdf.SaveAs("output.pdf");
        }
    }
}