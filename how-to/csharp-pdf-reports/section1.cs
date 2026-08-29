using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPdfReports
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer().RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
        }
    }
}