using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Responsive CSS rendering
renderer.RenderingOptions.PaperFit.UseResponsiveCssRendering(1280);

// Render web URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("responsiveCss.pdf");