using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlToPdfPageBreaks
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer()
              .RenderHtmlAsPdf("<html><body><h1>Hello World!</h1><div style='page-break-after: always;'></div></body></html>")
              .SaveAs("pageWithBreaks.pdf");
        }
    }
}