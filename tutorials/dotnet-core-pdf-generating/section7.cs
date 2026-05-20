using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section7
    {
        public static void Run()
        {
            // SecureAndSign.cs — .NET 8 LTS compatible
            using IronPdf;
            
            // Step 1: Load an existing PDF (or produce one with RenderHtmlAsPdf)
            PdfDocument pdf = PdfDocument.FromFile("financial-report.pdf");
            
            // Step 2: Configure AES-256 encryption & permissions
            pdf.SecuritySettings = new PdfSecuritySettings
            {
                EncryptionAlgorithm   = PdfEncryptionAlgorithm.AES256Bit,
                OwnerPassword         = "IronAdmin!2025",
                UserPassword          = "ReadOnly",
                AllowUserPrinting     = PdfPrintSecurity.Disabled,
                AllowUserCopyPasteContent = false,
                AllowUserAnnotations  = false
            };
            
            // Step 3: Digitally sign with a PFX certificate
            pdf.SignAndStamp(
                certificatePath : "./certs/ironsoftware.pfx",
                authority       : "Iron Software Ltd.",
                location        : "Chicago, IL",
                reason          : "Final approval"
            );
            
            // Step 4: Persist or stream
            pdf.SaveAs("financial-report-secured-signed.pdf");
        }
    }
}