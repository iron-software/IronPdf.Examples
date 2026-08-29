using IronPdf;
namespace IronPdf.Examples.HowTo.CustomMargins
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { MarginTop = 10, MarginBottom = 10, MarginLeft = 10, MarginRight = 10, UseMarginsOnHeaderAndFooter = IronPdf.UseMargins.All } }
                .RenderHtmlAsPdf("<h1>Hello with margins!</h1>")
                .SaveAs("custom-margins.pdf");
        }
    }
}