using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section12
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
        }
    }
}