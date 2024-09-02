using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderingOptions.ViewPortWidth = 1080;  //pixels

PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");