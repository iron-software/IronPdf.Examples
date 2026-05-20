using IronPdf;
namespace IronPdf.Examples.GettingStarted.VbNetPdf
{
    public static class Section6
    {
        public static void Run()
        {
            pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
        }
    }
}