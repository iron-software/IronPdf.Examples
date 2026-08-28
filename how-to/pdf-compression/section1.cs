using IronPdf;
namespace IronPdf.Examples.HowTo.PdfCompression
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = PdfDocument.FromFile("input.pdf");

            // CompressImages returns void, so it cannot be chained.
            pdf.CompressImages(40);
            pdf.SaveAs("compressed.pdf");
        }
    }
}