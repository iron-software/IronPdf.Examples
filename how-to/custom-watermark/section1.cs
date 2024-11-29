using IronPdf;
namespace ironpdf.CustomWatermark
{
    public class Section1
    {
        public void Run()
        {
            string watermarkHtml = @"
            <img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
            <h1>Iron Software</h1>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Watermark</h1>");
            
            // Apply watermark
            pdf.ApplyWatermark(watermarkHtml);
            
            pdf.SaveAs("watermark.pdf");
        }
    }
}