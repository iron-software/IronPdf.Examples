using IronPdf;

string html = @"
<!DOCTYPE html>
<html>
<head>
<meta charset=""utf-8"" />
<title>C3 Bar Chart</title>
</head>
<body>
<div id=""chart"" style=""width: 950px;""></div>
<script src=""https://d3js.org/d3.v4.js""></script>
<!-- Load c3.css -->
<link href=""https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.css"" rel=""stylesheet"">
<!-- Load d3.js and c3.js -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.js""></script>

<script>
Function.prototype.bind = Function.prototype.bind || function (thisp) {
    var fn = this;
    return function () {
        return fn.apply(thisp, arguments);
    };
};
var chart = c3.generate({
    bindto: '#chart',
    data: {
        columns: [['data1', 30, 200, 100, 400, 150, 250],
                  ['data2', 50, 20, 10, 40, 15, 25]]
    }
});
</script>
</body>
</html>
";

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Enable JavaScript
renderer.RenderingOptions.EnableJavaScript = true;
// Set waitFor for JavaScript
renderer.RenderingOptions.WaitFor.JavaScript(500);

// Render HTML contains JavaScript
var pdfJavaScript = renderer.RenderHtmlAsPdf(html);

// Export PDF
pdfJavaScript.SaveAs("renderChart.pdf");