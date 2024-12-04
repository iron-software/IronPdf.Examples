using IronPdf;

// Open an Encrypted File, alternatively create a new PDF from Html
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Get file metadata
System.Collections.Generic.List<string> metadatakeys = pdf.MetaData.Keys(); // returns {"Title", "Creator", ...}

// Remove file metadata
pdf.MetaData.RemoveMetaDataKey("Title");
metadatakeys = pdf.MetaData.Keys(); // return {"Creator", ...} // title was deleted

// Edit file metadata
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "SEO, Friendly";
pdf.MetaData.ModifiedDate = System.DateTime.Now;

// The following code makes a PDF read only and will disallow copy & paste and printing
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Change or set the document encryption password
pdf.SecuritySettings.OwnerPassword = "top-secret"; // password to edit the pdf
pdf.SecuritySettings.UserPassword = "sharable"; // password to open the pdf
pdf.SaveAs("secured.pdf");
