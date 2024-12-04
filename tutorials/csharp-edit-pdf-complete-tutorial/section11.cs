using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section11
    {
        public void Run()
        {
            var pdf = new PdfDocument("document.pdf");
            
            pdf.CompressImages(90, true);
            pdf.SaveAs("document_scaled_compressed.pdf");
        }
    }
}