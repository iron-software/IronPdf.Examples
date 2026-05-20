using IronPdf;
namespace IronPdf.Examples.HowTo.CustomMargins
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Set custom PDF margins in one line!
            new IronPdf.ChromePdfRenderer { RenderingOptions = { MarginTop = 10, MarginBottom = 10, MarginLeft = 10, MarginRight = 10, UseMarginsOnHeaderAndFooter = true } }
                .RenderHtmlAsPdf("<h1>Hello with margins!</h1>")
                .SaveAs("custom‑margins.pdf");
        }
    }
}