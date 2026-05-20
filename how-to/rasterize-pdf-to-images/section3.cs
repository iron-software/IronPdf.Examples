using IronPdf;
namespace IronPdf.Examples.HowTo.RasterizePdfToImages
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("url.pdf");
            
            var image = pdf.ToBitmapHighQuality();
            image[0].SaveAs("output.png");
        }
    }
}