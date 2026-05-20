using IronPdf;
namespace IronPdf.Examples.HowTo.Ironpdf2021ChromeRenderingEngineEap
{
    public static class Section2
    {
        public static void Run()
        {
            // Example of setting up RenderingOptions and HttpLoginCredentials in the new API
            var renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.CssMediaType.Screen;
            // Set HTTP credentials if needed
            renderer.RenderingOptions.HttpLoginCredentials.Username = "yourUsername";
            renderer.RenderingOptions.HttpLoginCredentials.Password = "yourPassword";
        }
    }
}