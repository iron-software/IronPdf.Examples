using IronPdf;

// For NEW PDF Documents use PdfPaperOrientation
// PdfPaperOrientation: To choose Landscape or Portrait Orientation in a new PDF document
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Landscape;

var newPdfFromHtml = renderer.RenderHtmlAsPdf("<h1> Hello World! </h1>");
var newPdfFromHtmlFile = renderer.RenderHtmlFileAsPdf("example.html");
var newPdfFromUrl = renderer.RenderUrlAsPdf("https://ironpdf.com");


// For EXISTING PDFs use PageRotation
// PageRotation : To rotate a PDF page and all of its  its contents
var existingPdf = new PdfDocument("old_report.pdf");

// Get rotation value
var getRotationFirstPage = existingPdf.Pages[0].PageRotation;

// Rotate specified page
existingPdf.SetPageRotation(PageIndex: 0, Rotation: IronPdf.Rendering.PdfPageRotation.Clockwise90);

// Rotate ALL pages
existingPdf.SetAllPageRotations(IronPdf.Rendering.PdfPageRotation.Clockwise270);
