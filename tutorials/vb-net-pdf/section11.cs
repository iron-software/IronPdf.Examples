using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section11
    {
        public static void Run()
        {
            pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
        }
    }
}