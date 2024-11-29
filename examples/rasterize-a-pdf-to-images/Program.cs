using IronPdf;
using IronSoftware.Drawing;

var pdf = PdfDocument.FromFile("Example.pdf");

// Extract all pages to a folder as image files
pdf.RasterizeToImageFiles(@"C:\image\folder\*.png");

// Dimensions and page ranges may be specified
pdf.RasterizeToImageFiles(@"C:\image\folder\example_pdf_image_*.jpg", 100, 80);

// Extract all pages as AnyBitmap objects
AnyBitmap[] pdfBitmaps = pdf.ToBitmap();
