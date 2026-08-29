using IronPdf;
namespace IronPdf.Examples.HowTo.BaseUrls
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<img src='icons/logo.png'>", @"C:\site\assets\").SaveAs("with‑assets.pdf");
        }
    }
}