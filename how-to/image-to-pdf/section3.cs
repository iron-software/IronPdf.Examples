using IronPdf.Imaging;
using IronPdf;
namespace ironpdf.ImageToPdf
{
    public class Section3
    {
        public void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            // Convert an image to a PDF with image behavior of centered on page
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, ImageBehavior.CenteredOnPage);
            
            // Export the PDF
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}