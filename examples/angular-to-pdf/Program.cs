using IronPdf;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Enable JavaScript in our RenderingOptions
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.WaitFor.JavaScript(500);

var pdfAngularJs = renderer.RenderUrlAsPdf("https://angular.io/");

// Export to a file or Stream
pdfAngularJs.SaveAs("angular.pdf");
