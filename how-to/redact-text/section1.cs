using IronPdf;
namespace IronPdf.Examples.HowTo.RedactText
{
    public static class Section1
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("novel.pdf");
            
            // Redact 'Alaric' phrase from all pages
            pdf.RedactTextOnAllPages("Alaric");
            
            pdf.SaveAs("redacted.pdf");
        }
    }
}