using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");