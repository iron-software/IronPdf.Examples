using IronPdf;
namespace IronPdf.Examples.HowTo.PageOrientationRotation
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("file.pdf");

            // SetAllPageRotations returns void, so it cannot be chained.
            pdf.SetAllPageRotations(IronPdf.Rendering.PdfPageRotation.Clockwise90);
            pdf.SaveAs("rotated.pdf");
        }
    }
}