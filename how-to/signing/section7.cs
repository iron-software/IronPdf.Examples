using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section7
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf");
            bool isValid = pdf.VerifyPdfSignatures();
        }
    }
}