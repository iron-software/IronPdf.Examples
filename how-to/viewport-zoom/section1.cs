using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Chrome default rendering
renderer.RenderingOptions.PaperFit.UseChromeDefaultRendering();

// Render web URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("chromeDefault.pdf");