using IronPdf;
namespace IronPdf.Examples.HowTo.TableOfContents
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Generate a PDF with a Table of Contents in one line!
            new ChromePdfRenderer { RenderingOptions = { CreateOutlineMaps = true, OutlineMapsFormat = TableOfContentsTypes.WithPageNumbers, FirstPageNumber = 1 } }
                .RenderHtmlFileAsPdf("myDocument.html")
                .SaveAs("withToc.pdf");
        }
    }
}