using IronPdf;
using System.Collections.Generic;

string html = @"<p> This is 1st Page </p>
<div style = 'page-break-after: always;'></div>
<p> This is 2nd Page</p>
<div style = 'page-break-after: always;'></div>
<p> This is 3rd Page</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Render background
PdfDocument background = renderer.RenderHtmlAsPdf("<body style='background-color: cyan;'></body>");

// Create list of pages
List<int> pages = new List<int>() { 0, 2 };

// Add background to page 1 & 3
pdf.AddBackgroundPdfToPageRange(pages, background);

pdf.SaveAs("addBackgroundOnMultiplePage.pdf");