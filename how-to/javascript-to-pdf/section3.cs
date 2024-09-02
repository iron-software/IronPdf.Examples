using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Method callback to be invoked whenever a browser console message becomes available:
renderer.RenderingOptions.JavascriptMessageListener = message => Console.WriteLine($"JS: {message}");
// Log 'foo' to the console
renderer.RenderingOptions.Javascript = "console.log('foo');";

// Render HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1> Hello World </h1>");

//--------------------------------------------------//
// Error will be logged
// message => Uncaught TypeError: Cannot read properties of null (reading 'style')
renderer.RenderingOptions.Javascript = "document.querySelector('non-existent').style.color='foo';";

// Render HTML to PDF
PdfDocument pdf2 = renderer.RenderHtmlAsPdf("<h1> Hello World </h1>");