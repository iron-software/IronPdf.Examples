using IronPdf;
using System;

//Open an Encrypted File, alternatively create a new PDF from Html

var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

//Edit file metadata
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "SEO, Friendly";
pdf.MetaData.ModifiedDate = DateTime.Now;

//Edit file security settings

//The following code makes a PDF read only and will disallow copy & paste and printing
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// change or set the document encrpytion password
pdf.Password = "my-password";
pdf.SaveAs("secured.pdf");
