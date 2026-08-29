using IronPdf;
namespace IronPdf.Examples.HowTo.RasterizePdfToImages
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("input.pdf").RasterizeToImageFiles("page_*.png");
        }
    }
}