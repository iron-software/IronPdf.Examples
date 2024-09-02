using IronPdf;
using System.Collections.Generic;
using System.Linq;

// Instantiate Renderer
var renderer = new IronPdf.ChromePdfRenderer();

var multi_page_html = @"
    <p> This is 1st Page</p>
        <div style = 'page-break-after: always;' ></div>
        <p> This is 2nd Page</p>
    <div style = 'page-break-after: always;' ></div>
        <p> This is 3rd Page</p>
    <div style = 'page-break-after: always;' ></div>
        <p> This is 4th Page</p>
    <div style = 'page-break-after: always;' ></div>
        <p> This is 5th Page</p>
    <div style = 'page-break-after: always;' ></div>
        <p> This is 6th Page</p>
    <div style = 'page-break-after: always;' ></div>
        <p> This is 7th Page</p>";

// Create a PDF or Load an existing PDF using IronPdf.PdfDocument.Load()
var pdfdoc = renderer.RenderHtmlAsPdf(multi_page_html);


// Create a Header
var header = new HtmlHeaderFooter();
header.HtmlFragment = "THIS IS HEADER {page} of {total-pages}";

// Create a Page Range  0 .. 7
var allPageIndexes = Enumerable.Range(0, pdfdoc.PageCount);

// Example 1
// Apply header to even page index only. (page number will be odd number because index start at 0 but page number start at 1)
var evenPageIndexes = allPageIndexes.Where(i => i % 2 == 0);
pdfdoc.AddHtmlHeaders(header, 1, evenPageIndexes);
pdfdoc.SaveAs("EvenPages.pdf");

// Example 2
//Apply header to odd page index only. (page number will be even number because index start at 0 but page number start at 1)
var oddPageIndexes = allPageIndexes.Where(i => i % 2 != 0);
pdfdoc.AddHtmlHeaders(header, 1, oddPageIndexes);
pdfdoc.SaveAs("OddPages.pdf");

// Example 3
// Apply header to last page only.
var lastPageIndex = new List<int>() { pdfdoc.PageCount - 1 };
pdfdoc.AddHtmlHeaders(header, 1, lastPageIndex);
pdfdoc.SaveAs("LastPageOnly.pdf");

// Example 4
// Apply header to first page only.
var firstPageIndex = new List<int>() { 0 };
pdfdoc.AddHtmlHeaders(header, 1, firstPageIndex);
pdfdoc.SaveAs("FirstPageOnly.pdf");

// Example 5
// Skip the first page.
var skipFirstPageIndexes5 = allPageIndexes.Skip(1);
pdfdoc.AddHtmlHeaders(header, 1, skipFirstPageIndexes5);
pdfdoc.SaveAs("SkipFirstPage.pdf");

// Example 6
// Skip first page and make second pages label as 1.
var skipFirstPageIndexes6 = allPageIndexes.Skip(1);
pdfdoc.AddHtmlHeaders(header, 0, skipFirstPageIndexes6);
pdfdoc.SaveAs("SkipFirstPageAndDontCountIt.pdf");
