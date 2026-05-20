using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section3
    {
        public static void Run()
        {
            // Create the Chrome renderer
            var renderer = new ChromePdfRenderer();
            
            // Convert HTML string to PDF
            var pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            
            // Save the PDF
            pdf.SaveAs("output.pdf");
        }
    }
}