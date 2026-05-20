using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlZipFileToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert your HTML ZIP archive to PDF with one line!
            new IronPdf.ChromePdfRenderer().RenderZipFileAsPdf("htmlSample.zip", "htmlSample.html").SaveAs("output.pdf");
        }
    }
}