using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section13
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
            renderer.RenderingOptions.PrintHtmlBackgrounds = false;
            renderer.RenderingOptions.CreatePdfFormsFromHtml = false;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        }
    }
}