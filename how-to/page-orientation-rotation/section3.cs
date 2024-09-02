using IronPdf;
using IronPdf.Rendering;

PdfDocument pdf = PdfDocument.FromFile("rotatedLandscape.pdf");

PdfPageRotation rotation = pdf.GetPageRotation(1);