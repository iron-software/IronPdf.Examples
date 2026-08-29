using IronPdf;
namespace IronPdf.Examples.HowTo.ColorGrayscale
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.GrayScale = true;
            var pdf = renderer.RenderUrlAsPdf("https://example.com");
            pdf.SaveAs("grayscale.pdf");
        }
    }
}