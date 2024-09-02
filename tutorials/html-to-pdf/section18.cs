using IronPdf;

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf(htmlInstance);
pdf.SaveAs("Handlebars.pdf");