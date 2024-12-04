using IronPdf;
namespace ironpdf.Signing
{
    public class Section6
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
            pdf.RemoveSignatures();
        }
    }
}