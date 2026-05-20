using IronPdf;
namespace IronPdf.Examples.HowTo.SanitizePdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Sanitize a PDF in one call!
            IronPdf.Cleaner.SanitizeWithSvg(PdfDocument.FromFile("input.pdf")).SaveAs("sanitized.pdf");
        }
    }
}