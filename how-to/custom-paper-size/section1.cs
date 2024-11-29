using IronPdf;
namespace ironpdf.CustomPaperSize
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set custom paper size in cm
            renderer.RenderingOptions.SetCustomPaperSizeinCentimeters(15, 15);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Paper Size</h1>");
            
            pdf.SaveAs("customPaperSize.pdf");
        }
    }
}