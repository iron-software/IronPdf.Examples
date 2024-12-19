using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section4
    {
        public static void Run()
        {
            var pdfs = new List<PdfDocument>
            {
                PdfDocument.FromFile("A.pdf"),
                PdfDocument.FromFile("B.pdf"),
                PdfDocument.FromFile("C.pdf")
            };
            
            PdfDocument mergedPdf = PdfDocument.Merge(pdfs);
            mergedPdf.SaveAs("merged.pdf");
            
            foreach (var pdf in pdfs)
            {
                pdf.Dispose();
            }
        }
    }
}