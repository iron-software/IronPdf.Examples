using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section6
    {
        public void Run()
        {
            // Create a PDF Chart a live rendered dataset using d3.js and javascript
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
            pdf.SaveAs("chart.pdf");
        }
    }
}