using IronPdf;
using System;

var renderOptions = new ChromePdfRenderOptions
{
    // Method callback to be invoked whenever a browser console message becomes available:
    JavascriptMessageListener = message => Console.WriteLine($"JS: {message}"),
    Javascript = "console.log('foo');",
};

var pdf = new ChromePdfRenderer { RenderingOptions = renderOptions }.RenderHtmlAsPdf("<h1> Hello World </h1>");

// Example of JavaScript that will cause an error:
renderOptions.Javascript = "document.querySelector('non-existent').style.color='foo';";
// message => Uncaught TypeError: Cannot read properties of null (reading 'style')
