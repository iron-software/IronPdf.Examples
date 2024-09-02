using IronPdf;

var pdf = PdfDocument.FromFile("protected.pdf", "password123");

//... perform PDF-tasks

pdf.SaveAs("protected_2.pdf"); // Saved as another file