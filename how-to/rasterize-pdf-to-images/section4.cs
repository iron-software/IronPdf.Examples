using IronPdf;
using System.Linq;

// Instantiate Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render PDF from web URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Export images from PDF page 1_3
pdf.RasterizeToImageFiles("wikipage_*.png", Enumerable.Range(1, 3));