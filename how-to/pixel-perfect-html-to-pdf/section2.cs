// Example using PdfCssMediaType.Screen
IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen; // or Print
renderer.RenderingOptions.PrintHtmlBackgrounds = true;