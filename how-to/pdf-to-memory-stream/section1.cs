using IronPdf;
namespace IronPdf.Examples.HowTo.PdfToMemoryStream
{
    public static class Section1
    {
        public static void Run()
        {
            using var stream = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Hello Stream!</h1>").Stream;
        }
    }
}