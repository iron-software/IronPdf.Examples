using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Add page numbers in one line!
            new IronPdf.ChromePdfRenderer { RenderingOptions = { HtmlFooter = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<center>{page}of{total-pages}</center>", DrawDividerLine = true } } }
                 .RenderHtmlAsPdf("<h1>My multi‑page document</h1><div style='page‑break‑after:always;'></div><h1>Page 2</h1>")
                 .SaveAs("numbered‑pages.pdf");
        }
    }
}