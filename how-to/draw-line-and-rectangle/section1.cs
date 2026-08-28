using IronPdf;
namespace IronPdf.Examples.HowTo.DrawLineAndRectangle
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.DrawLine(0,
                new IronSoftware.Drawing.PointF(10, 10),
                new IronSoftware.Drawing.PointF(200, 10),
                2,
                new IronSoftware.Drawing.Color("#FF0000"));
            pdf.SaveAs("output.pdf");
        }
    }
}