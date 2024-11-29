using IronPdf;

const string html = @"<p>Lorem ipsum dolor sit amet...";

var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.Custom;
renderer.RenderingOptions.SetCustomPaperSizeInInches(5f, 5f);

var pdf = renderer.RenderHtmlAsPdf(html);

pdf.SaveAs("CustomPaperSize.pdf");
