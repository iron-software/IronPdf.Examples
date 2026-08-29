using IronPdf.Security;
using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section7
    {
        public static void Run()
        {
            // SecureAndSign.cs — .NET 8 LTS compatible
            
            // Step 1: Load an existing PDF (or produce one with RenderHtmlAsPdf)
            PdfDocument pdf = PdfDocument.FromFile("financial-report.pdf");
            
            // Step 2: Configure AES-256 encryption & permissions. SecuritySettings
            // is read-only, so each setting is assigned in place.
            pdf.SecuritySettings.EncryptionType = IronPdf.Security.PdfEncryptionType.Aes_256;
            pdf.SecuritySettings.OwnerPassword = "IronAdmin!2025";
            pdf.SecuritySettings.UserPassword = "ReadOnly";
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.NoPrint;
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserAnnotations = false;
            
            // Step 3: Digitally sign with a PFX certificate. There is no
            // SignAndStamp; SignWithFile takes the certificate and its password.
            pdf.SignWithFile("./certs/ironsoftware.pfx", "certificate-password");
            
            // Step 4: Persist or stream
            pdf.SaveAs("financial-report-secured-signed.pdf");
        }
    }
}