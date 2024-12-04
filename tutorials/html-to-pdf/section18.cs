using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section18
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf(htmlInstance);
            pdf.SaveAs("Handlebars.pdf");
        }
    }
}