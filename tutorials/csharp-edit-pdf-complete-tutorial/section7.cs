using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section7
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