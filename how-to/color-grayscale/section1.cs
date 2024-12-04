using IronPdf;
namespace ironpdf.ColorGrayscale
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set GrayScale to true
            renderer.RenderingOptions.GrayScale = true;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironsoftware.com/");
            pdf.CopyPage(0).SaveAs("test.pdf");
        }
    }
}