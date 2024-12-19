using IronPdf;
namespace IronPdf.Examples.HowTo.GeneratePdfInCsharp
{
    public static class Section2
    {
        public static void Run()
        {
            Renderer.RenderingOptions.EnableJavaScript = true;
            Renderer.RenderingOptions.RenderDelay = 500; // milliseconds
        }
    }
}