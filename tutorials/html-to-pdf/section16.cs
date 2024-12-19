using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section16
    {
        public static void Run()
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