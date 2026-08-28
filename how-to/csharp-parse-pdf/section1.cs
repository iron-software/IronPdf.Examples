using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpParsePdf
{
    public static class Section1
    {
        public static void Run()
        {
            var text = IronPdf.PdfDocument.FromFile("sample.pdf").ExtractAllText();
        }
    }
}