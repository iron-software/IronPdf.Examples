using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Render background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Add background to page 1
pdf.AddBackgroundPdfToPage(0, background);

pdf.SaveAs("addBackgroundOnASinglePage.pdf");