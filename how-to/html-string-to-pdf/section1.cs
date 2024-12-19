using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlStringToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from a HTML string using C#
            var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            
            // Export to a file or Stream
            pdf.SaveAs("output.pdf");
        }
    }
}