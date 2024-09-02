using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Change paper orientation
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

pdf.SaveAs("landscape.pdf");