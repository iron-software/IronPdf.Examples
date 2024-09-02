var pdf = new PdfDocument("sample.pdf");

// Take the first page
var pdf_page1 = pdf.CopyPage(0);
pdf_page1.SaveAs("Split1.pdf");

// Take the pages 2 & 3
var pdf_page2_3 = pdf.CopyPages(1, 2);
pdf_page2_3.SaveAs("Spli2t.pdf");