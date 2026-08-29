using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument pdf = IronPdf.PdfDocument.FromFile("example.pdf");
            pdf.SaveAsPdfA("output.pdf");
        }
    }
}