using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.BaseUrls
{
    public static class Section3
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Add header
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                MaxHeight = 20,
                HtmlFragment = "<img src='logo.png'>",
                BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
            };
        }
    }
}