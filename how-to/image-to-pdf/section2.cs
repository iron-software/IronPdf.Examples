using System.Linq;
using IronPdf;
namespace ironpdf.ImageToPdf
{
    public class Section2
    {
        public void Run()
        {
            // Retrieve all JPG and JPEG image paths in the 'images' folder.
            IEnumerable<String> imagePaths = Directory.EnumerateFiles("images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            
            // Convert images to a PDF
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePaths);
            
            // Export the PDF
            pdf.SaveAs("imagesToPdf.pdf");
        }
    }
}