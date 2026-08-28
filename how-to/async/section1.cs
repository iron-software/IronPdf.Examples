using IronPdf;
namespace IronPdf.Examples.HowTo.Async
{
    public static class Section1
    {
        public static async Task Run()
        {
            var pdf = await new IronPdf.ChromePdfRenderer().RenderHtmlAsPdfAsync("<h1>Hello World!</h1>");
        }
    }
}