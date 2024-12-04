using IronPdf;
namespace ironpdf.CsharpPdfReports
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
        }
    }
}