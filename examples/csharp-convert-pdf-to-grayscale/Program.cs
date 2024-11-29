using IronPdf;

var renderer = new ChromePdfRenderer();

// Set Color and Grayscale
renderer.RenderingOptions.GrayScale = true;

renderer.RenderHtmlFileAsPdf("my-content.html").SaveAs("my-content.pdf");
