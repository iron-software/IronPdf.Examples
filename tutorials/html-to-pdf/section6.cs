using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section6
    {
        public static void Run()
        {
            // Create a PDF Chart a live rendered dataset using d3.js and javascript
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
            pdf.SaveAs("chart.pdf");
        }
    }
}