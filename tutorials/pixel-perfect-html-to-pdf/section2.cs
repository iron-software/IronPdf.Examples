// Example using PdfCssMediaType.Screen
IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen; // or Print
renderer.RenderingOptions.PrintHtmlBackgrounds = true;