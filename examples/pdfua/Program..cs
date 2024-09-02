using IronPdf;

// Open a PDF or use an exisiting PdfDocument object
PdfDocument pdf = PdfDocument.FromFile("source_doc.pdf");

// Save the PDF/UA Document to File
pdf.SaveAsPdfUA("pdfua-compliant.pdf");
