using IronPdf;
namespace IronPdf.Examples.HowTo.PdfToHtml
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert PDFs Instantly to HTML
            IronPdf.PdfDocument.FromFile("example.pdf").SaveAsHtml("output.html");
        }
    }
}