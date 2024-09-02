using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set GrayScale to true
renderer.RenderingOptions.GrayScale = true;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironsoftware.com/");
pdf.CopyPage(0).SaveAs("test.pdf");