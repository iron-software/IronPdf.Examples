using IronPdf;
using IronPdf.Editing;

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
// Watermarks all pages with red "SAMPLE" text at a custom location.
// Also adding a link to the watermark on-click
pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 0, VerticalAlignment.Middle, HorizontalAlignment.Center);
pdf.SaveAs(@"C:\Path\To\Watermarked.pdf");