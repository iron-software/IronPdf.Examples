using IronPdf;

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World<h1>");
pdf.SaveAs("html-string.pdf");

var pdf_url = renderer.RenderUrlAsPdf("<h1>Hello World<h1>");
pdf_url.SaveAs("url.pdf");
