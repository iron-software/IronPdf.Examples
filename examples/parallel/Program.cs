using IronPdf;
using System.Collections.Generic;
using System.Threading.Tasks;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

var htmlStrings = new List<string> { "<h1>Html#1</h1>", "<h1>Html#2</h1>", "<h1>Html#3</h1>" };

Parallel.ForEach(htmlStrings, (html) =>
{
    var pdf = renderer.RenderHtmlAsPdf(html);
    // do something with each pdfDocument
});
