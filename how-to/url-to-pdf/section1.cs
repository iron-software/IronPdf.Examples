using IronPdf;
namespace IronPdf.Examples.HowTo.UrlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer().RenderUrlAsPdf("https://example.com").SaveAs("example.pdf");
        }
    }
}