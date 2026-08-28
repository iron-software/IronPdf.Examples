using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section6
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Report</h1><p>Body</p>");
            var header = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<span>Page {page} of {total-pages}</span>" };
            var allPageIndices = Enumerable.Range(0, pdf.PageCount);

            // Get odd page indexes (resulting in even page numbers)
            var oddPageIndexes = allPageIndices.Where(i => i % 2 != 0);
            
            pdf.AddHtmlHeaders(header, 1, oddPageIndexes);
            pdf.SaveAs("OddPages.pdf");
        }
    }
}