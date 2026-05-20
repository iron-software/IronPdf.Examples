using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert PDFs to PDF/A-3 Effortlessly
            IronPdf.PdfDocument pdf = IronPdf.PdfDocument.FromFile("example.pdf");
            pdf.SaveAsPdfA("output.pdf");
        }
    }
}