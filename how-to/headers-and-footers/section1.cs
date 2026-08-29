using IronPdf;
namespace IronPdf.Examples.HowTo.HeadersAndFooters
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { TextHeader = new IronPdf.TextHeaderFooter { CenterText = "Report • {date}" }, TextFooter = new IronPdf.TextHeaderFooter { RightText = "Page {page} of {total‑pages}" } } }
                .RenderHtmlAsPdf("<h1>Hello World!</h1>")
                .SaveAs("withHeadersFooters.pdf");
        }
    }
}