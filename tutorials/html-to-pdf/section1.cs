using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.ChromePdfRenderer
                   .StaticRenderHtmlAsPdf("<p>Hello World</p>")
                   .SaveAs("pixelperfect.pdf");
        }
    }
}