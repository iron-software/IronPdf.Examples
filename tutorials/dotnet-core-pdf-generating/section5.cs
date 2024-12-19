using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section5
    {
        public static void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            // Open an unencrypted pdf
            PdfDocument unencryptedPdf = PdfDocument.FromFile("testFile.pdf");
            
            // Open an encrypted pdf
            PdfDocument encryptedPdf = PdfDocument.FromFile("testFile2.pdf", "MyPassword");
        }
    }
}