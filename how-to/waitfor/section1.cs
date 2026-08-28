using IronPdf;
namespace IronPdf.Examples.HowTo.Waitfor
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();

            // WaitFor is configured by calling it, not by assigning to it.
            renderer.RenderingOptions.WaitFor.RenderDelay(3000);

            renderer.RenderUrlAsPdf("https://example.com").SaveAs("output.pdf");
        }
    }
}