using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section3
    {
        public static void Run()
        {
            // Create a PDF from any existing web page
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/PDF");
            pdf.SaveAs("wikipedia.pdf");
        }
    }
}