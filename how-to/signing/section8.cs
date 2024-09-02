using IronPdf;
using IronPdf.Editing;

var pdf = PdfDocument.FromFile("invoice.pdf");

pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

pdf.SaveAs("official_invoice.pdf");