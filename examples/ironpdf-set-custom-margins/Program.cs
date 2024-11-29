using IronPdf;

var renderer = new ChromePdfRenderer();

// Set Margins (in millimeters)
renderer.RenderingOptions.MarginTop = 40;
renderer.RenderingOptions.MarginLeft = 20;
renderer.RenderingOptions.MarginRight = 20;
renderer.RenderingOptions.MarginBottom = 40;

renderer.RenderHtmlFileAsPdf("my-content.html").SaveAs("my-content.pdf");
