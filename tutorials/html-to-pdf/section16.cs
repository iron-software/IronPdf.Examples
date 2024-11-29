using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section16
    {
        public void Run()
        {
            var htmlTemplate = "<p>[[NAME]]</p>";
            var names = new[] { "John", "James", "Jenny" };
            foreach (var name in names)
            {
                var htmlInstance = htmlTemplate.Replace("[[NAME]]", name);
                var pdf = renderer.RenderHtmlAsPdf(htmlInstance);
                pdf.SaveAs(name + ".pdf");
            }
        }
    }
}