using IronPdf;
namespace ironpdf.Signing
{
    public class Section7
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf");
            bool isValid = pdf.VerifyPdfSignatures();
        }
    }
}