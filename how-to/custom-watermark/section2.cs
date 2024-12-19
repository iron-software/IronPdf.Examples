using IronPdf.Editing;
using IronPdf;
namespace IronPdf.Examples.HowTo.CustomWatermark
{
    public static class Section2
    {
        public static void Run()
        {
            string watermarkHtml = @"
            <img style='width: 200px;' src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
            <h1>Iron Software</h1>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");
            
            // Apply watermark with 45 degrees rotation and 70% opacity
            pdf.ApplyWatermark(watermarkHtml, rotation: 45, opacity: 70);
            
            pdf.SaveAs("watermarkOpacity&Rotation.pdf");
        }
    }
}