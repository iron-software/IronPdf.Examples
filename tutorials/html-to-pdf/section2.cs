using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section2
    {
        public void Run()
        {
            // this will render C:\MyProject\Assets\image1.png
            var pdf = renderer.RenderHtmlAsPdf("<img src='image1.png'/>", @"C:\MyProject\Assets\");
        }
    }
}