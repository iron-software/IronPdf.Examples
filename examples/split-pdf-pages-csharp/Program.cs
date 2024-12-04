using IronPdf;

const string html =
    @"<p> Hello Iron </p>
    <p> This is 1st Page </p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 2nd Page</p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 3rd Page</p>";

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf(html);

//take the first page
var page1doc = pdf.CopyPage(0);
page1doc.SaveAs("Split1.pdf");

//take the pages 2 & 3
var page23doc = pdf.CopyPages(1, 2);
page23doc.SaveAs("Split2.pdf");
