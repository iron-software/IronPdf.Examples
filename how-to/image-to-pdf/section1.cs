using IronPdf;

string imagePath = "meetOurTeam.jpg";

// Convert an image to a PDF
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath);

// Export the PDF
pdf.SaveAs("imageToPdf.pdf");