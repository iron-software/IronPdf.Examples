using IronPdf;
namespace ironpdf.HtmlFileToPdf
{
    public class Section3
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure the rendering options to default Chrome options
            renderer.RenderingOptions = ChromePdfRenderOptions.DefaultChrome;
        }
    }
}