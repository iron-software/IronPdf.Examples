using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlZipFileToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderZipFileAsPdf("htmlSample.zip", @"htmlSample.html");
            
            pdf.SaveAs("output.pdf");
        }
    }
}