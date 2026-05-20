using IronPdf;
namespace IronPdf.Examples.HowTo.PrintPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Print PDFs Effortlessly with IronPDF
            IronPdf.PdfDocument.FromFile("example.pdf").Print();
        }
    }
}