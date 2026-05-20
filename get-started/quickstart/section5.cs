using IronPdf;
namespace IronPdf.Examples.GettingStarted.Quickstart
{
    public static class Section5
    {
        public static void Run()
        {
            IronPdf.ChromePdfRender
                   .StaticRenderHtmlAsPdf("<p>Hello Word</p>")
                   .SaveAs("string-to-pdf.pdf");
        }
    }
}