using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.MarginTop = 40;
            renderer.RenderingOptions.MarginLeft = 20;
            renderer.RenderingOptions.MarginRight = 20;
            renderer.RenderingOptions.MarginBottom = 40;
        }
    }
}