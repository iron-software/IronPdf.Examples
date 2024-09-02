using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Open the image from file
AnyBitmap bitmap = AnyBitmap.FromFile("ironSoftware.png");

// Draw the bitmp on PDF
pdf.DrawBitmap(bitmap, 0, 50, 250, 500, 300);

pdf.SaveAs("drawImage.pdf");