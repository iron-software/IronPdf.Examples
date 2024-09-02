using IronPdf;

string html = @"<p> .NET6 </p>
<p> This is 1st Page </p>
<div style = 'page-break-after: always;'></div>
<p> This is 2nd Page</p>
<div style = 'page-break-after: always;'></div>
<p> .NET6 </p>
<p> This is 3rd Page</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

string oldText = ".NET6";
string newText = ".NET7";

int[] pages = { 0, 2 };

// Replace text on page 1 & 3
pdf.ReplaceTextOnPages(pages, oldText, newText);

pdf.SaveAs("replaceTextOnMultiplePages.pdf");