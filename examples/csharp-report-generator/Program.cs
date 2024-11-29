using IronPdf;

var renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderFileAsPdf("report.html").SaveAs("report.pdf");
