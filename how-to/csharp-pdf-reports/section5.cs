using IronPdf.Signing;
using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPdfReports
{
    public static class Section5
    {
        public static void Run()
        {
            // Sign our PDF Report using a p12 or pix digital certificate file
            new PdfSignature("IronSoftware.pfx", "123456").SignPdfFile("signed.pdf");
        }
    }
}