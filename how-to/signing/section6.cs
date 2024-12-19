using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section6
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
            pdf.RemoveSignatures();
        }
    }
}