using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section12
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            // Open an unencrypted pdf
            PdfDocument unencryptedPdf = PdfDocument.FromFile("testFile.pdf");
            
            // Open an encrypted pdf
            PdfDocument encryptedPdf = PdfDocument.FromFile("testFile2.pdf", "MyPassword");
        }
    }
}