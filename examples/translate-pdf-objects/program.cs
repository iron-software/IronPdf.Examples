using IronPdf;
using System.Linq;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render simple HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("Test");

// Access the first text object on the first page
var objects = pdf.Pages.First().ObjectModel.TextObjects.First();

// Translate by 100 points right and 100 points down
objects.Translate = new System.Drawing.PointF(100, -100);

// Save the modified PDF
pdf.SaveAs("translated.pdf");
