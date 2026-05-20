using IronPdf;
namespace IronPdf.Examples.HowTo.Waitfor
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Delay rendering until content is ready in one line!
            new IronPdf.ChromePdfRenderer { RenderingOptions = { WaitFor = IronPdf.WaitFor.RenderDelay(3000) } }
                .RenderUrlAsPdf("https://example.com")
                .SaveAs("output.pdf");
        }
    }
}