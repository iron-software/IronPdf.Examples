using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlStringToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert HTML to PDF Instantly
            IronPdf.ChromePdfRender.StaticRenderHtmlAsPdf("<p>Hello World</p>").SaveAs("string-to-pdf.pdf");
        }
    }
}