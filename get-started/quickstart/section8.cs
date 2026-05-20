using IronPdf;
namespace IronPdf.Examples.GettingStarted.Quickstart
{
    public static class Section8
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