using IronPdf;
namespace IronPdf.Examples.HowTo.PdfImageFlattenCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");

            // Flatten returns void, so it cannot be chained.
            pdf.Flatten();
            pdf.SaveAs("flattened.pdf");
        }
    }
}