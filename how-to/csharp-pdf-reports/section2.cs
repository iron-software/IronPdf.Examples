using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPdfReports
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
        }
    }
}