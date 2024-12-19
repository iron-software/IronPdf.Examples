using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section19
    {
        public static void Run()
        {
            var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
            var pdfMerged = PdfDocument.Merge(new PdfDocument("CoverPage.pdf"), pdf).SaveAs("Combined.Pdf");
        }
    }
}