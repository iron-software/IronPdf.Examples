using IronPdf.Imaging;
using IronPdf;
namespace IronPdf.Examples.HowTo.ImageToPdf
{
    public static class Section3
    {
        public static void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            // Convert an image to a PDF with image behavior of centered on page
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, ImageBehavior.CenteredOnPage);
            
            // Export the PDF
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}