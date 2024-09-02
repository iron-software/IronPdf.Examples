using IronPdf;
using IronPdf.Rendering;

renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
// or
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;