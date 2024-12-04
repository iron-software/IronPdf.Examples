using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section3
    {
        public void Run()
        {
            // Create a PDF from any existing web page
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/PDF");
            pdf.SaveAs("wikipedia.pdf");
        }
    }
}