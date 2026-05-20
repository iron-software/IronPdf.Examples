using IronPdf;
namespace IronPdf.Examples.HowTo.DrawLineAndRectangle
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Create Shapes in PDF Quickly
            IronPdf.PdfDocument pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.DrawLine(10, 10, 200, 10, "#FF0000", 2);
            pdf.SaveAs("output.pdf");
        }
    }
}