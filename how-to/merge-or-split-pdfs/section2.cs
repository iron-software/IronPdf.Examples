using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("Merged.pdf");

// New wdith and heights are in millimeters
PdfDocument combinedPages = pdf.CombinePages(250, 250, 2, 2);

combinedPages.SaveAs("combinePages.pdf");