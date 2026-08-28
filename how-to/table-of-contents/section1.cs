using IronPdf;
namespace IronPdf.Examples.HowTo.TableOfContents
{
    public static class Section1
    {
        public static void Run()
        {
            new ChromePdfRenderer { RenderingOptions = { TableOfContents = IronPdf.TableOfContentsTypes.WithPageNumbers, AutoBookmarksFromHeadings = true, FirstPageNumber = 1 } }
                .RenderHtmlFileAsPdf("myDocument.html")
                .SaveAs("withToc.pdf");
        }
    }
}