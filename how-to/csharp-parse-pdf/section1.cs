using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpParsePdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Parse PDFs Instantly with IronPDF
            var text = IronPdf.FromFile("sample.pdf").ExtractAllText();
        }
    }
}