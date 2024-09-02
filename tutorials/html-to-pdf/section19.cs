using IronPdf;

var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
var pdfMerged = PdfDocument.Merge(new PdfDocument("CoverPage.pdf"), pdf).SaveAs("Combined.Pdf");