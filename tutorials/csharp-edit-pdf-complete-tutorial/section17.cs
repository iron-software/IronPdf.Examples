using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section17
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            pdf.AddBackgroundPdf(@"MyBackground.pdf");
            pdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);
            pdf.SaveAs(@"C:\Path\To\Complete.pdf");
        }
    }
}