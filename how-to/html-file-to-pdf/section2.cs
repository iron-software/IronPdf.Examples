using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlFileToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions = new ChromePdfRenderOptions
                {
                    CssMediaType = PdfCssMediaType.Print,
                    MarginBottom = 0,
                    MarginLeft = 0,
                    MarginRight = 0,
                    MarginTop = 0,
                    Timeout = 120,
                },
            };
            renderer.RenderingOptions.WaitFor.RenderDelay(50);
            
            // Create a PDF from an existing HTML file using C#
            var pdf = renderer.RenderHtmlFileAsPdf("example.html");
            
            // Export to a file or Stream
            pdf.SaveAs("output.pdf");
        }
    }
}