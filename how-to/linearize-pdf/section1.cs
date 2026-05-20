using IronPdf;
namespace IronPdf.Examples.HowTo.LinearizePdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Optimize PDFs Instantly - Try IronPDF Now
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.SaveAsLinearized(pdf.BinaryData, "linearized.pdf");
        }
    }
}