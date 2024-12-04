using IronPdf;

var renderOptions = new ChromePdfRenderOptions();

// Example that change all to red style in JavaScript:
renderOptions.Javascript = "document.querySelectorAll('h1').forEach(function(el){el.style.color='red';})";

// Make sure to use the render options object that you created:
var renderer = new ChromePdfRenderer { RenderingOptions = renderOptions };
var pdf = renderer.RenderHtmlAsPdf("<h1>Happy New Year!</h1>");
pdf.SaveAs("executed_js.pdf");
