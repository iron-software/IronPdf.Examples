using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Build a footer using html to style the text
// mergeable fields are:
// {page} {total-pages} {url} {date} {time} {html-title} & {pdf-title}
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    MaxHeight = 30,
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
    DrawDividerLine = true
};

// Build a header using an image asset
// Note the use of BaseUrl to set a relative path to the assets
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 30,
    HtmlFragment = "<img src='logo.jpg'>",
    BaseUrl = new Uri(@"C:\assets\images").AbsoluteUri
};
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World<h1>");
pdf.SaveAs("html-string.pdf");