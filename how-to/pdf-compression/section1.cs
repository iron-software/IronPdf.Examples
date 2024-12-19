using IronPdf;
namespace IronPdf.Examples.HowTo.PdfCompression
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Compress images in the PDF
            pdf.CompressImages(40);
            
            pdf.SaveAs("compressed.pdf");
        }
    }
}