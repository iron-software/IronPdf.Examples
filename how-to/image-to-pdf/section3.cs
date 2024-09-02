using IronPdf;
using IronPdf.Imaging;

string imagePath = "meetOurTeam.jpg";

// Convert an image to a PDF with image behavior of centered on page
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, ImageBehavior.CenteredOnPage);

// Export the PDF
pdf.SaveAs("imageToPdf.pdf");