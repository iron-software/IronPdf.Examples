using IronPdf;
namespace IronPdf.Examples.HowTo.RotatingText
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");

            // SetAllPageRotations returns void, so it cannot be chained.
            pdf.SetAllPageRotations(IronPdf.Rendering.PdfPageRotation.Clockwise90);
            pdf.SaveAs("rotated.pdf");
        }
    }
}