using IronPdf;
namespace IronPdf.Examples.HowTo.Async
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert HTML to PDF Quickly!
            var pdf = await IronPdf.ChromePdfRenderer.RenderHtmlAsPdfAsync("<h1>Hello World!</h1>");
        }
    }
}