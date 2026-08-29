using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section2
    {
        public static void Run()
        {
            // Pixel Perfect HTML Formatting Settings
            IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print; // or Screen
        }
    }
}