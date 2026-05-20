using IronPdf;
namespace IronPdf.Examples.HowTo.RedactText
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Redact PDF Text Instantly
            IronPdf.PdfDocument doc = IronPdf.PdfDocument.FromFile("document.pdf");
            doc.RedactTextOnAllPages("sensitive info");
            doc.SaveAs("redacted_document.pdf");
        }
    }
}