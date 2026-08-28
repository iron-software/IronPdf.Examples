using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section8
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Report</h1><p>Body</p>");
            var header = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<span>Page {page} of {total-pages}</span>" };

            // First page only
            var firstPageIndex = new List<int>() { 0 };
            
            pdf.AddHtmlHeaders(header, 1, firstPageIndex);
            pdf.SaveAs("FirstPageOnly.pdf");
        }
    }
}