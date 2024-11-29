using IronPdf;

const string exampleMdString = "This text is ***really important***.";

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Load the MD (Markdown) as File or String
PdfDocument pdfFromFile = renderer.RenderMarkdownFileAsPdf("report.md");
PdfDocument pdfFromString = renderer.RenderMarkdownStringAsPdf(exampleMdString);

pdfFromFile.SaveAs("report.pdf");
pdfFromString.SaveAs("string.pdf");
