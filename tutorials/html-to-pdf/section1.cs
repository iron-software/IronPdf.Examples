using IronPdf;

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1> Hello IronPdf </h1>");
pdf.SaveAs("pixel-perfect.pdf");