using IronPdf;
namespace IronPdf.Examples.HowTo.Ironpdf2021ChromeRenderingEngineEap
{
    public static class Section2
    {
        public static void Run()
        {
            // Example of setting up RenderingOptions and HttpLoginCredentials in the new API
            var renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;

            // Credentials belong to the renderer, not to its rendering options.
            renderer.LoginCredentials = new IronPdf.ChromeHttpLoginCredentials
            {
                NetworkUsername = "yourUsername",
                NetworkPassword = "yourPassword"
            };
        }
    }
}