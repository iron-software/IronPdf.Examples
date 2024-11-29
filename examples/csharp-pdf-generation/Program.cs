using IronPdf;

var renderer = new ChromePdfRenderer();

renderer.RenderHtmlAsPdf("<h1>Hello World<h1>").SaveAs("html-string.pdf");

renderer.RenderUrlAsPdf("www.google.com").SaveAs("url.pdf");
