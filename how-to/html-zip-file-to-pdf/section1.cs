using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlZipFileToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer().RenderZipFileAsPdf("htmlSample.zip", "htmlSample.html").SaveAs("output.pdf");
        }
    }
}