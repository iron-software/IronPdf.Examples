using IronPdf;

// Render any HTML fragment or document to HTML
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");

var outputPath = "ChromePdfRenderer.pdf";

// Export PDF document
pdf.SaveAs(outputPath);

// This neat trick opens our PDF file so we can see the result in our default PDF viewer
System.Diagnostics.Process.Start(outputPath);