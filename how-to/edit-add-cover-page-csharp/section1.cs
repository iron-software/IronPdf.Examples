using IronPdf;

// Instantiate Chrome renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render cover page
PdfDocument coverPdf = renderer.RenderHtmlAsPdf("<h1> This is Cover Page</h1>");

// Convert URL to PDF
PdfDocument onlinePdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");

// Merge and save PDF.
PdfDocument.Merge(coverPdf, onlinePdf).SaveAs("combined.pdf");