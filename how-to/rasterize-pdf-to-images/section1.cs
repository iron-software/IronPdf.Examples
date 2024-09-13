using IronPdf;

// Instantiate Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render PDF from web URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Export images from PDF
pdf.RasterizeToImageFiles("wikipage_*.png");