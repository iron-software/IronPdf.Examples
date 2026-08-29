using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section7
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Report</h1><p>Body</p>");
            var header = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<span>Page {page} of {total-pages}</span>" };

            // Last page only
            var lastPageIndex = new List<int>() { pdf.PageCount - 1 };
            
            pdf.AddHtmlHeaders(header, 1, lastPageIndex);
            pdf.SaveAs("LastPageOnly.pdf");
        }
    }
}