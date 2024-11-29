using IronPdf.Signing;
using IronPdf;
namespace ironpdf.CsharpPdfReports
{
    public class Section3
    {
        public void Run()
        {
            // Sign our PDF Report using a p12 or pix digital certificate file
            new PdfSignature("IronSoftware.pfx", "123456").SignPdfFile("signed.pdf");
        }
    }
}