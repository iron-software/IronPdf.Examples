using IronPdf;
using System;

// Instantiate Renderer
var renderer = new IronPdf.ChromePdfRenderer();


// Build a footer using html to style the text
// mergeable fields are:
// {page} {total-pages} {url} {date} {time} {html-title} & {pdf-title}
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    MaxHeight = 15, //millimeters
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
    DrawDividerLine = true
};

// Use sufficient MarginBottom to ensure that the HtmlFooter does not overlap with the main PDF page content.
renderer.RenderingOptions.MarginBottom = 25; //mm


// Build a header using an image asset
// Note the use of BaseUrl to set a relative path to the assets
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20, //millimeters
    HtmlFragment = "<img src='logo.png'>",
    BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
};

// Use sufficient MarginTop to ensure that the HtmlHeader does not overlap with the main PDF page content.
renderer.RenderingOptions.MarginTop = 25; //mm
