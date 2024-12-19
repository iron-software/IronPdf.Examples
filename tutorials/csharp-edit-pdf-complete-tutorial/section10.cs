using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section10
    {
        public static void Run()
        {
            var pdf = new PdfDocument("document.pdf");
            
            // Quality parameter can be 1-100, where 100 is 100% of original quality
            pdf.CompressImages(60);
            pdf.SaveAs("document_compressed.pdf");
        }
    }
}