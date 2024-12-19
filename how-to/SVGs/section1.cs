using IronPdf;
namespace IronPdf.Examples.HowTo.SVGs
{
    public static class Section1
    {
        public static void Run()
        {
            string html = "<img src='https://ironsoftware.com/img/svgs/new-banner-svg.svg' style='width:100px'>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.WaitFor.RenderDelay(1000);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            pdf.SaveAs("svgToPdf.pdf");
        }
    }
}