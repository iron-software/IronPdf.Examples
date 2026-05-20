using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlFileToPdf
{
    public static class Section4
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure the rendering options to default Chrome options
            renderer.RenderingOptions = ChromePdfRenderOptions.DefaultChrome;
        }
    }
}