using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text from page 1
string textFromPage1 = pdf.ExtractTextFromPage(0);

int[] pages = new[] { 0, 2 };

// Extract text from pages 1 & 3
string textFromPage1_3 = pdf.ExtractTextFromPages(pages);