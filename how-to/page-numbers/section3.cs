using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section3
    {
        public static void Run()
        {
            string multi_page_html = @"
                <p>This is the 1st Page</p>
            <div style = 'page-break-after: always;' ></div>
                <p>This is the 2nd Page</p>
            <div style = 'page-break-after: always;' ></div>
                <p>This is the 3rd Page</p>
            <div style = 'page-break-after: always;' ></div>
                <p>This is the 4th Page</p>
            <div style = 'page-break-after: always;' ></div>
                <p>This is the 5th Page</p>
            <div style = 'page-break-after: always;' ></div>
                <p>This is the 6th Page</p>
            <div style = 'page-break-after: always;' ></div>
                <p>This is the 7th Page</p>";
            
            // Create header
            HtmlHeaderFooter header = new HtmlHeaderFooter()
            {
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
            };
            
            // Render PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf(multi_page_html);
            
            // Create a Page Range 0..6
            var allPageIndices = Enumerable.Range(0, pdf.PageCount);
        }
    }
}