using IronPdf;

// Open a PDF or use an exisiting PdfDocument object
PdfDocument pdf = PdfDocument.FromFile("source_doc.pdf");

// Perform PDF Editing Tasks...

// Save the PDF/A-3b Document to File
pdf.SaveAsPdfA("pdfa-compliant.pdf", PdfAVersions.PdfA3b);
