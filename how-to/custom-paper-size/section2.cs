using IronPdf;
using IronPdf.Editing;

PdfDocument pdf = PdfDocument.FromFile("customPaperSize.pdf");

pdf.ExtendPage(0, 50, 0, 0, 0, MeasurementUnit.Millimeter);

pdf.SaveAs( "extendedLeftSide.pdf");