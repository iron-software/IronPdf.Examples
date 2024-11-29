using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section20
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            IronPdf.Signing.PdfSignature signature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");
            
            // Optional signing options
            signature.SigningContact = "support@ironsoftware.com";
            signature.SigningLocation = "Chicago, USA";
            signature.SigningReason = "To show how to sign a PDF";
            
            // Sign the PDF with the PdfSignature. Multiple signing certificates may be used
            pdf.Sign(signature);
        }
    }
}