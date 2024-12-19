using IronPdf;
namespace IronPdf.Examples.HowTo.ColorGrayscale
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set GrayScale to true
            renderer.RenderingOptions.GrayScale = true;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironsoftware.com/");
            pdf.CopyPage(0).SaveAs("test.pdf");
        }
    }
}