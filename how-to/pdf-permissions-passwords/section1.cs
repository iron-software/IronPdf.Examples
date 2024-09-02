using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Secret Information:</h1> Hello World");

// Password to edit the pdf
pdf.SecuritySettings.OwnerPassword = "123password";

// Password to open the pdf
pdf.SecuritySettings.UserPassword = "password123";

pdf.SaveAs("protected.pdf");