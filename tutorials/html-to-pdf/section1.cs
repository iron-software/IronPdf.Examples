using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<h1> Hello IronPdf </h1>");
            pdf.SaveAs("pixel-perfect.pdf");
        }
    }
}