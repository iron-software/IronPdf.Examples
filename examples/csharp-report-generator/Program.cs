using IronPdf;

var renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
