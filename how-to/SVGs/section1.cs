using IronPdf.Engines.Chrome;
using IronPdf;
namespace IronPdf.Examples.HowTo.SVGs
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.WaitFor.RenderDelay(1000);

            renderer.RenderHtmlAsPdf("<img src='https://example.com/logo.svg' style='width:100px;height:100px;'>")
                .SaveAs("svgToPdf.pdf");
        }
    }
}