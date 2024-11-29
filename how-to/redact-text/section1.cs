using IronPdf;
namespace ironpdf.RedactText
{
    public class Section1
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("novel.pdf");
            
            // Redact 'Alaric' phrase from all pages
            pdf.RedactTextOnAllPages("Alaric");
            
            pdf.SaveAs("redacted.pdf");
        }
    }
}