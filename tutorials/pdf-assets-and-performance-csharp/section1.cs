using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Enhance PDFs Quickly with IronPDF
            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Hello Performance</h1>").CompressImages(50).Flatten().SaveAs("fast‑optimized.pdf");
        }
    }
}