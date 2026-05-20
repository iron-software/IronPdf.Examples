using IronPdf;
namespace IronPdf.Examples.HowTo.RasterizePdfToImages
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Rasterize a PDF to image files in one line!
            IronPdf.PdfDocument.FromFile("input.pdf").RasterizeToImageFiles("page_*.png");
        }
    }
}