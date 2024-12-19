using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            // this will render C:\MyProject\Assets\image1.png
            var pdf = renderer.RenderHtmlAsPdf("<img src='image1.png'/>", @"C:\MyProject\Assets\");
        }
    }
}