using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section20
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.MarginTop = 40;
            renderer.RenderingOptions.MarginLeft = 20;
            renderer.RenderingOptions.MarginRight = 20;
            renderer.RenderingOptions.MarginBottom = 40;
        }
    }
}