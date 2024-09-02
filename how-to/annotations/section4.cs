using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Remove all annotaions on a specified page
pdf.Annotations.RemoveAllAnnotationsForPage(0);

// Remove all annotaions on the document
pdf.Annotations.Clear();

pdf.SaveAs("removeAllAnnotation.pdf");