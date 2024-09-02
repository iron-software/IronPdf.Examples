using IronPdf;

// Create a PDF from an existing HTML using C#
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlFileAsPdf("Assets/MyHTML.html");
pdf.SaveAs("MyPdf.pdf");