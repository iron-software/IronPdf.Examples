using IronPdf;
namespace IronPdf.Examples.Example.MergePdfs
{
    public static class Section1
    {
        public static void Run()
        {
            List<PdfDocument> pdfs = new List<PdfDocument>()
            {
                pdfdoc_a,
                pdfdoc_b,
                pdfdoc_c,
                // ...
            };
            var merged = PdfDocument.Merge(pdfs);
            merged.SaveAs("Merged.pdf");
        }
    }
}