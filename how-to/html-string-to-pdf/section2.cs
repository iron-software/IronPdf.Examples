using IronPdf;
namespace ironpdf.HtmlStringToPdf
{
    public class Section2
    {
        public void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Advanced Example with HTML Assets
            // Load external html assets: Images, CSS and JavaScript.
            // An optional BasePath 'C:\site\assets\' is set as the file location to load assets from
            var myAdvancedPdf = renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");
            myAdvancedPdf.SaveAs("html-with-assets.pdf");
        }
    }
}