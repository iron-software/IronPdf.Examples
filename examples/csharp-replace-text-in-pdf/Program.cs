using IronPdf;

// Using an existing PDF
var pdf = PdfDocument.FromFile("sample.pdf");

// Parameters
const int pageIndex = 1;
const string oldText = ".NET 6"; // Old text to remove
const string newText = ".NET 7"; // New text to add

// Replace Text on Page
pdf.ReplaceTextOnPage(pageIndex, oldText, newText);

// Save your new PDF
pdf.SaveAs("new_sample.pdf");
