using IronPdf;
namespace ironpdf.PdfPermissionsPasswords
{
    public class Section3
    {
        public void Run()
        {
            // Open an Encrypted File, alternatively create a new PDF from HTML
            var pdf = PdfDocument.FromFile("protected.pdf", "password123");
            
            // Edit file security settings
            // The following code makes a PDF read only and will disallow copy & paste and printing
            pdf.SecuritySettings.RemovePasswordsAndEncryption();
            pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
            pdf.SecuritySettings.AllowUserAnnotations = false;
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserFormData = false;
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;
            
            // Save the secure PDF
            pdf.SaveAs("secured.pdf");
        }
    }
}