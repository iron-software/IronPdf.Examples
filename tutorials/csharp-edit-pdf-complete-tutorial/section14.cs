// Using an existing PDF
var pdf = PdfDocument.FromFile("sample.pdf");

// Parameters
int pageIndex = 1;
string oldText = ".NET 6"; // Old text to remove
string newText = ".NET 7"; // New text to add

// Replace Text on Page
pdf.ReplaceTextOnPage(pageIndex, oldText, newText);

// Placeholder Template Example
pdf.ReplaceTextOnPage(pageIndex, "[DATE]", "01/01/2000");

// Save your new PDF
pdf.SaveAs("new_sample.pdf");