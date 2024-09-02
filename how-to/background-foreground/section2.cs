using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");

// Render foreground
PdfDocument foreground = renderer.RenderHtmlAsPdf("<h1 style='transform: rotate(-45deg); opacity: 50%;'>Overlay Watermark</h1>");

// Overlay foreground
pdf.AddForegroundOverlayPdf(foreground);

pdf.SaveAs("overlayForeground.pdf");