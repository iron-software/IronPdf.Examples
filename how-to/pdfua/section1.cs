using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfua
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Create PDF/UA with IronPDF
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.SaveAsPdfUA("output_pdfua.pdf");
        }
    }
}