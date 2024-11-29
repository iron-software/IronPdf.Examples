using IronPdf;
using IronPdf.Engines.Chrome;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Set the width of the Responsive Viewport in pixels
int pixelWidth = 1280;
renderer.RenderingOptions.PaperFit.UseResponsiveCssRendering(pixelWidth);

// Set paper mode to automatic fit to physical paper
renderer.RenderingOptions.FitToPaperMode = FitToPaperModes.AutomaticFit;

// Render an HTML file
var pdf = renderer.RenderHtmlFileAsPdf("Assets/Responsive.html");
