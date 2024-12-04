using IronPdf;

// 4-Paged HTML Document example:
const string html =
    @"<p> Hello Iron</p>
    <p> This is 1st Page </p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 2nd Page</p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 3rd Page</p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 4th Page</p>";


var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf(html);

// Remove a pages 2 & 3.  Similar syntax to to Substring
pdf.RemovePages(1, 2);

pdf.SaveAs("Page1And4.pdf");
