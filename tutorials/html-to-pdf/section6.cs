using IronPdf;

// Create a PDF Chart a live rendered dataset using d3.js and javascript
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
pdf.SaveAs("chart.pdf");