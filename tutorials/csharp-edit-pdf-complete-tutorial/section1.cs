var pdf = new PdfDocument("report.pdf");
var renderer = new ChromePdfRenderer();
var coverPagePdf = renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");
pdf.PrependPdf(coverPagePdf);
pdf.SaveAs("report_with_cover.pdf");