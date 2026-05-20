using IronPdf;
namespace IronPdf.Examples.HowTo.BaseUrls
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Render HTML with assets via BaseUrl in one line!
            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<img src='icons/logo.png'>", @"C:\site\assets\").SaveAs("with‑assets.pdf");
        }
    }
}