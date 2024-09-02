using IronPdf;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

var htmlStrings = new List<string>() { "<h1>Html#1</h1>", "<h1>Html#2</h1>", "<h1>Html#3</h1>" };

Task<PdfDocument[]> task = Task.WhenAll(htmlStrings.Select(html => renderer.RenderHtmlAsPdfAsync(html)));

List<PdfDocument> pdfList = task.Result.ToList();

// Do something with the pdfDocuments
