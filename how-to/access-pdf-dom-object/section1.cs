using IronPdf;
namespace IronPdf.Examples.HowTo.AccessPdfDomObject
{
    public static class Section1
    {
        public static void Run()
        {
            var objs = new IronPdf.ChromePdfRenderer().RenderUrlAsPdf("https://example.com").Pages.First().ObjectModel;
        }
    }
}