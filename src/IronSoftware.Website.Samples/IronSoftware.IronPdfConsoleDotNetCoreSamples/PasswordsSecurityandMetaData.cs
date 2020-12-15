using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class PasswordsSecurityandMetaData : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {

            //Open an Encrypted File, alternatively create a new PDF from Html
            PdfDocument Pdf = PdfDocument.FromFile(@"Inputs\FileWithPassword.pdf", "12345678");
            //Edit file metadata
            Pdf.MetaData.Author = "Satoshi Nakamoto";
            Pdf.MetaData.Keywords = "SEO, Friendly";
            Pdf.MetaData.ModifiedDate = DateTime.Now;
            //Edit file security settings
            //The following code makes a PDF read only and will disallow copy & paste and printing
            Pdf.SecuritySettings.RemovePasswordsAndEncryption();
            Pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
            Pdf.SecuritySettings.AllowUserAnnotations = false;
            Pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            Pdf.SecuritySettings.AllowUserFormData = false;
            Pdf.SecuritySettings.AllowUserPrinting = PdfDocument.PdfSecuritySettings.PdfPrintSecrity.FullPrintRights;
            //Change or set the document ecrpytion password
            Pdf.Password = "12345678";
            Pdf.SaveAs($@"{OutputPath}\PasswordsSecurityandMetaData.pdf");

        }
    }
}
