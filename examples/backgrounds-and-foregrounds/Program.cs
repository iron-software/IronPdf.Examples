using IronPdf;

// With IronPDF, we can easily merge 2 PDF files using one as a background or foreground
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
pdf.AddBackgroundPdf(@"MyBackground.pdf");
pdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);
pdf.SaveAs(@"C:\Path\To\Complete.pdf");
