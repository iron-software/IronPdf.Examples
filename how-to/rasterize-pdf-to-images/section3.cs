using IronPdf;
namespace ironpdf.RasterizePdfToImages
{
    public class Section3
    {
        public void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render PDF from web URL
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Export images from PDF with DPI 150
            pdf.RasterizeToImageFiles("wikipage_*.png", DPI: 150);
        }
    }
}