using IronPdf;
using System.Text;

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.SetCustomPaperSizeInInches(12.5, 20);
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait;
renderer.RenderingOptions.Title = "My PDF Document Name";
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.WaitFor.RenderDelay(50);
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.GrayScale = false;
renderer.RenderingOptions.FitToPaperMode = IronPdf.Engines.Chrome.FitToPaperModes.Automatic;
renderer.RenderingOptions.InputEncoding = Encoding.UTF8;
renderer.RenderingOptions.Zoom = 100;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Change margins (millimeters)
renderer.RenderingOptions.MarginTop = 40;
renderer.RenderingOptions.MarginLeft = 20;
renderer.RenderingOptions.MarginRight = 20;
renderer.RenderingOptions.MarginBottom = 40;

// Use 2 if a cover page will be appended
renderer.RenderingOptions.FirstPageNumber = 1;
renderer.RenderHtmlFileAsPdf("my-content.html").SaveAs("my-content.pdf");