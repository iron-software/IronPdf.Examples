using IronPdf;
namespace ironpdf.Ironpdf2021ChromeRenderingEngineEap
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
            renderer.RenderingOptions.PrintHtmlBackgrounds = false;
            renderer.RenderingOptions.CreatePdfFormsFromHtml = false;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        }
    }
}