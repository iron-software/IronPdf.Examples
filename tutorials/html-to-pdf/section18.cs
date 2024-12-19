using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section18
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf(htmlInstance);
            pdf.SaveAs("Handlebars.pdf");
        }
    }
}