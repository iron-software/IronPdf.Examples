using IronPdf;
namespace IronPdf.Examples.HowTo.PdfVersions
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            var pdf = renderer.RenderHtmlAsPdf("<p> Hello World!</p>");
            
            pdf.SaveAs("output.pdf");
        }
    }
}