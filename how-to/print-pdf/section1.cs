using IronPdf;
namespace IronPdf.Examples.HowTo.PrintPdf
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("example.pdf").Print();
        }
    }
}