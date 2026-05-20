using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section5
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