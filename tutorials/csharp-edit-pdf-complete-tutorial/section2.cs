var pdf = new PdfDocument("report.pdf");
// Copy pages 5 to 7 and save them as a new document.
pdf.CopyPages(4, 6).SaveAs("report_highlight.pdf");