using IronPdf.Editing;
using IronPdf;
namespace ironpdf.CustomWatermark
{
    public class Section3
    {
        public void Run()
        {
            string watermarkHtml = @"
            <img style='width: 200px;' src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
            <h1>Iron Software</h1>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");
            
            // Apply watermark on the top-right of the document
            pdf.ApplyWatermark(watermarkHtml, 50, VerticalAlignment.Top, HorizontalAlignment.Right);
            
            pdf.SaveAs("watermarkLocation.pdf");
        }
    }
}