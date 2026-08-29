using IronPdf;
namespace IronPdf.Examples.HowTo.PdfToHtml
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("example.pdf").SaveAsHtml("output.html");
        }
    }
}