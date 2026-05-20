using IronPdf;
namespace IronPdf.Examples.Tutorial.OrganizePdfsCompleteTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Organize PDFs Instantly
            IronPdf.PdfDocument.Merge(
                IronPdf.PdfDocument.FromFile("file1.pdf"), 
                IronPdf.PdfDocument.FromFile("file2.pdf"))
                .SaveAs("merged.pdf");
        }
    }
}