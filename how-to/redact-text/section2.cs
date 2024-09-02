using IronPdf;
using IronSoftware.Drawing;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

RectangleF rectangle = new RectangleF(5, 700, 50, 50);

// Redact region on coordinates(5,700) with width and height 50 pixels
pdf.RedactRegionsOnAllPages(rectangle);

pdf.SaveAs("redactedRegion.pdf");