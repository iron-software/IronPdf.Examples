using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Remove a single annotation with specified index
pdf.Annotations.RemoveAt(1);

pdf.SaveAs("removeSingleAnnotation.pdf");