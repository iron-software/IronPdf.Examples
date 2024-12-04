using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section17
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            pdf.AddBackgroundPdf(@"MyBackground.pdf");
            pdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);
            pdf.SaveAs(@"C:\Path\To\Complete.pdf");
        }
    }
}