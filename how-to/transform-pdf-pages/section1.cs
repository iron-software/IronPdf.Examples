using IronPdf;
namespace IronPdf.Examples.HowTo.TransformPdfPages
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Transform PDF pages with translation and scaling in one line!
            IronPdf.PdfDocument.FromFile("input.pdf")
              .Pages[0].Transform(50,50,0.8,0.8)
              .SaveAs("output‑transformed.pdf");
        }
    }
}