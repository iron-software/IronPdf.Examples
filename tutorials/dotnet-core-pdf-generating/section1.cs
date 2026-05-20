using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert HTML to PDF Instantly
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Hello World</h1>");
        }
    }
}