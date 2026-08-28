using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Hello Performance</h1>");

            // CompressImages and Flatten both return void, so neither can be chained.
            pdf.CompressImages(50);
            pdf.Flatten();
            pdf.SaveAs("fast-optimized.pdf");
        }
    }
}