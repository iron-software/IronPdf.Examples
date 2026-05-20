using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section7
    {
        public static void Run()
        {
            // Create renderer for JavaScript-heavy HTML
            var renderer = new ChromePdfRenderer();
            
            // Convert d3.js visualization web page to PDF
            var pdf = renderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
            
            // Save the interactive chart as static PDF
            pdf.SaveAs("chart.pdf");
        }
    }
}