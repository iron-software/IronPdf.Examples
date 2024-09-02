using IronPdf;

// Use the Chrome Renderer to make beautiful HTML designs
var chromeRenderer = new ChromePdfRenderer();

// Render an HTML design as a PdfDocument object using Chrome
PdfDocument pdf = chromeRenderer.RenderHtmlAsPdf("design.html");

// Use the SaveAsPdfA method to save to file
pdf.SaveAsPdfA("design-accessible.pdf", PdfAVersions.PdfA3b);