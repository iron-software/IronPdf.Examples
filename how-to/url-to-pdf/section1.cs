using IronPdf;
namespace IronPdf.Examples.HowTo.UrlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert URL to PDF Instantly!
            new IronPdf.ChromePdfRenderer().RenderUrlAsPdf("https://example.com").SaveAs("example.pdf");
        }
    }
}