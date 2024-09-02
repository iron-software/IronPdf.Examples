using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Get PrintDocument object
var printDocument = pdf.GetPrintDocument();

// Subscribe to the PrintPage event
var printedPages = 0;
printDocument.PrintPage += (sender, args) => printedPages++;

// Print document
printDocument.Print();