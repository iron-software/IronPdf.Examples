using IronPdf;
namespace IronPdf.Examples.HowTo.ImageToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            // Convert an image to a PDF
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath);
            
            // Export the PDF
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}