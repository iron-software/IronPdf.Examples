using IronPdf;
namespace IronPdf.Examples.HowTo.Azure
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.ChromePdfRenderer()
                .RenderHtmlAsPdf("<h1>Hello Azure!</h1>")
                .SaveAs("output‑azure.pdf");
        }
    }
}