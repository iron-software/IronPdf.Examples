using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.AccessPdfDomObject
{
    public static class Section6
    {
        public static void Run()
        {
            // Load the PDF file we created in the Scale example
             PdfDocument pdf = PdfDocument.FromFile("BeforeScale.pdf");
            
             // Access DOM Objects
             IPdfPageObjectModel objects = pdf.Pages.First().ObjectModel;
            
             // Remove first image
             objects.ImageObjects.RemoveAt(0);
            
             // Save the modified PDF
             pdf.SaveAs("removedFirstImage.pdf");
        }
    }
}