using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section10
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Report</h1><p>Body</p>");
            var header = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<span>Page {page} of {total-pages}</span>" };
            var allPageIndices = Enumerable.Range(0, pdf.PageCount);

            // Skip the first page and start numbering the second page as page 1
            var skipFirstPageAndDontCountIt = allPageIndices.Skip(1);
            
            pdf.AddHtmlHeaders(header, 0, skipFirstPageAndDontCountIt);
            pdf.SaveAs("SkipFirstPageAndDontCountIt.pdf");
        }
    }
}