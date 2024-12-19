using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section11
    {
        public static void Run()
        {
            var pdf = new PdfDocument("document.pdf");
            
            pdf.CompressImages(90, true);
            pdf.SaveAs("document_scaled_compressed.pdf");
        }
    }
}