using System.Drawing;
using IronPdf;
namespace IronPdf.Examples.HowTo.SigningPdfWithHsm
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Testing</h1>");
            
            // Define Paths and Credentials
            string softhsmLibraryPath = @"D:\SoftHSM2\lib\softhsm2-x64.dll";
            // These MUST match what you created
            string hsmTokenLabel = "MyTestToken";
            string hsmPin = "123456";
            string hsmKeyLabel = "my-key"; // The label for the key *inside* the token
            
            // Create the HsmSigner object.
            UsbPkcs11HsmSigner hsmSigner = new UsbPkcs11HsmSigner(
                softhsmLibraryPath,
                hsmPin,
                hsmTokenLabel,
                hsmKeyLabel
            );
            
            // Create the Signature Image
            string signatureImagePath = "IronSoftware.png";
            PdfSignatureImage sigImage = new PdfSignatureImage(signatureImagePath, 0, new Rectangle(50, 50, 150, 150));
            
            // Sign PDF with HSM
            pdf.SignAndSave("signedWithHSM.pdf", hsmSigner);
        }
    }
}