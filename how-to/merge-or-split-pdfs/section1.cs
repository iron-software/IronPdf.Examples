using IronPdf;
namespace IronPdf.Examples.HowTo.MergeOrSplitPdfs
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Merge multiple PDFs into one with a single call!
            IronPdf.PdfDocument
                .Merge(IronPdf.PdfDocument.FromFile("file1.pdf"), IronPdf.PdfDocument.FromFile("file2.pdf"))
                .SaveAs("merged.pdf");
        }
    }
}