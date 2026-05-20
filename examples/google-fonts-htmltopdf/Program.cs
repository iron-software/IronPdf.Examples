using IronPdf;

var htmlWithFont =
    @"<link href=""https://fonts.googleapis.com/css?family=Lobster""rel=""stylesheet""><p style=""font-family: 'Lobster', serif; font-size:30px;"" > Hello Google Fonts</p>";

// Instantiate Renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.AllFontsLoaded();

var doc = renderer.RenderHtmlAsPdf(htmlWithFont);

// Export to a file or Stream
doc.SaveAs("font.pdf");
