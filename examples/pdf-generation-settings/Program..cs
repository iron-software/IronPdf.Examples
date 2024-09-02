using IronPdf;
using IronPdf.Engines.Chrome;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Many rendering options to use to customize!
renderer.RenderingOptions.SetCustomPaperSizeInInches(12.5, 20);
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Landscape;
renderer.RenderingOptions.Title = "My PDF Document Name";
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.WaitFor.RenderDelay(50); // in milliseconds
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.FitToPaperMode = FitToPaperModes.Zoom;
renderer.RenderingOptions.Zoom = 100;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Supports margin customization!
renderer.RenderingOptions.MarginTop = 40; //millimeters
renderer.RenderingOptions.MarginLeft = 20; //millimeters
renderer.RenderingOptions.MarginRight = 20; //millimeters
renderer.RenderingOptions.MarginBottom = 40; //millimeters

// Can set FirstPageNumber if you have a cover page
renderer.RenderingOptions.FirstPageNumber = 1; // use 2 if a cover page will be appended

// Settings have been set, we can render:
renderer.RenderHtmlFileAsPdf("assets/wikipedia.html").SaveAs("output/my-content.pdf");
