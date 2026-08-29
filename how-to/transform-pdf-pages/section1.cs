using IronPdf;
namespace IronPdf.Examples.HowTo.TransformPdfPages
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");

            // Transform returns void, so it cannot be chained.
            pdf.Pages[0].Transform(50, 50, 0.8, 0.8);
            pdf.SaveAs("output-transformed.pdf");
        }
    }
}