using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Configure the required parameters
int pageIndex = 0;
var rectangle = new IronSoftware.Drawing.RectangleF(200, 100, 1000, 100);
var lineColor = new IronSoftware.Drawing.Color("#000000");
var fillColor = new IronSoftware.Drawing.Color("#32AB90");
int lineWidth = 5;

// Draw rectangle on PDF
pdf.DrawRectangle(pageIndex, rectangle, lineColor, fillColor, lineWidth);

pdf.SaveAs("drawRectangle.pdf");