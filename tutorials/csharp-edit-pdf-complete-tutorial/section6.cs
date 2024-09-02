// Open an Encrypted File, alternatively create a new PDF from Html
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Edit file metadata
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "SEO, Friendly";
pdf.MetaData.ModifiedDate = System.DateTime.Now;

// Edit file security settings
// The following code makes a PDF read only and will disallow copy & paste and printing
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Change or set the document encryption password
pdf.SecuritySettings.OwnerPassword = "top-secret"; // password to edit the pdf
pdf.SecuritySettings.UserPassword = "shareable";  // password to open the pdf
pdf.SaveAs("secured.pdf");