using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section21
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