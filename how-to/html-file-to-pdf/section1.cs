using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlFileToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer()
              .RenderHtmlFileAsPdf("path/to/your/file.html")
              .SaveAs("output.pdf");
        }
    }
}