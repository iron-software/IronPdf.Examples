using IronPdf;

const string htmlWithJavaScript = @"
<h1>This is HTML</h1>
<script>
    document.write('<h1>This is JavaScript</h1>');
    window.ironpdf.notifyRender();
</script>";

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Enable JavaScript in our RenderingOptions
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.WaitFor.JavaScript();

var pdfJavaScript = renderer.RenderHtmlAsPdf(htmlWithJavaScript);

// Export to a file or Stream
pdfJavaScript.SaveAs("javascript-in-html.pdf");
