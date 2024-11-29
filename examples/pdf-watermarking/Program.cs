using IronPdf;

// Stamps a Watermark onto a new or existing PDF
var renderer = new ChromePdfRenderer();

var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 30, IronPdf.Editing.VerticalAlignment.Middle, IronPdf.Editing.HorizontalAlignment.Center);
pdf.SaveAs(@"C:\Path\To\Watermarked.pdf");
