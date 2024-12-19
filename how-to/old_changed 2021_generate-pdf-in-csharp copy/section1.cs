using IronPdf;
namespace IronPdf.Examples.HowTo.Old_Changed 2021_GeneratePdfInCsharp Copy
{
    public static class Section1
    {
        public static void Run()
        {
            /**
            Set Viewport
            anchor-generate-pdf-with-custom-viewport
            **/
            using IronPdf;
            IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();
            
             //Choose screen or print CSS media
            Renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
            
            //Set the width of the responsive virtual browser window in pixels
            Renderer.ViewPortWidth = 1280; 
            
            // Render an HTML document or snippet as a string
            Renderer.RenderHTMLFileAsPdf("Assets/Responsive.html");
        }
    }
}