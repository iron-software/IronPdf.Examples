using IronPdf;

// Import cover page
PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");

// Import content document
PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");

// Insert PDF
contentPage.InsertPdf(coverPage, 0);