using IronPdf;
using System;

// Instantiate ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Add header
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20,
    HtmlFragment = "<img src='logo.png'>",
    BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
};