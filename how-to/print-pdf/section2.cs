using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");

// Set custom DPI
pdf.Print(300);

// Specify printing resolution
pdf.Print(10, 10, "Microsoft Print to PDF");