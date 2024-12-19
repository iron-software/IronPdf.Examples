using IronPdf;
namespace IronPdf.Examples.HowTo.Ironpdf2021ChromeRenderingEngineEap
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate renderer class
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Apply rendering options
            renderer.RenderingOptions.PaperFit.UseFitToPageRendering();
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            // Render to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello world!</h1>");
            // PdfDocument pdf = Renderer.RenderUrlAsPdf("https://www.google.com/");
            // PdfDocument pdf = Renderer.RenderHtmlFileAsPdf("example.html");
            pdf.SaveAs("google_chrome.pdf");
        }
    }
}