using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section11
    {
        public static void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            
            // Edit file metadata
            pdf.MetaData.Author = "john smith";
            pdf.MetaData.Keywords = "SEO, Friendly";
            pdf.MetaData.ModifiedDate = DateTime.Now;
            
            // Edit file security settings
            // The following code makes a PDF read only and will disallow copy & paste and printing
            pdf.SecuritySettings.RemovePasswordsAndEncryption();
            pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key"); //secret-key is a owner password
            pdf.SecuritySettings.AllowUserAnnotations = false;
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserFormData = false;
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;
            
            // Change or set the document ecrpytion password
            pdf.Password = "123";
            pdf.SaveAs("secured.pdf");
        }
    }
}