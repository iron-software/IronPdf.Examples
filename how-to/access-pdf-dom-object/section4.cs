using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.AccessPdfDomObject
{
    public static class Section4
    {
        public static void Run()
        {
            // Setup the Renderer
            var renderer = new ChromePdfRenderer();
            
            // We use CSS Flexbox to perfectly center the text vertically and horizontally.
            var html = @"
            <div style='display: flex; justify-content: center; align-items: center; font-size: 48px;'>
                Centered
            </div>";
            
            // Render the HTML to a PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Save the original PDF to see the "before" state
            pdf.SaveAs("BeforeTranslate.pdf");
            
            // Access the first text object on the first page
            // In this simple HTML, this will be our "Centered" text block.
            var textObject = pdf.Pages.First().ObjectModel.TextObjects.First();
            
            // Apply the translation
            // This moves the object 200 points to the right and 150 points up from its original position.
            textObject.Translate = new PointF(200, 150);
            
            // Save the modified PDF to see the "after" state
            pdf.SaveAs("AfterTranslate.pdf");
        }
    }
}