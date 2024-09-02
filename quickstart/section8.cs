using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World<h1>");
pdf.Password = "strong!@#pass&^%word";
pdf.SaveAs("secured.pdf");