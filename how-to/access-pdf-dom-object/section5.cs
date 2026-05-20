using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.AccessPdfDomObject
{
    public static class Section5
    {
        public static void Run()
        {
            // Setup the Renderer
            var renderer = new ChromePdfRenderer();
            
            // The image is placed in a div to give it some space on the page.
            string html = @"<img src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTi8LuOR6_A98euPLs-JRwoLU7Nc31nVP15rw&s'>";
            
            // Render the HTML to a PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Save the PDF before scaling for comparison
            pdf.SaveAs("BeforeScale.pdf");
            
            // Access the first image object on the first page
            var image = pdf.Pages.First().ObjectModel.ImageObjects.First();
            
            // We scale the image to 70% of its original size on both the X and Y axes.
            image.Scale = new PointF(0.7f, 0.7f);
            
            // Save the modified PDF to see the result
            pdf.SaveAs("AfterScale.pdf");
        }
    }
}