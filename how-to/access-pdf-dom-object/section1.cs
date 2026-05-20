using IronPdf;
namespace IronPdf.Examples.HowTo.AccessPdfDomObject
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Access and modify PDF DOM objects in one line!
            var objs = IronPdf.ChromePdfRenderer.RenderUrlAsPdf("https://example.com").Pages.First().ObjectModel;
        }
    }
}