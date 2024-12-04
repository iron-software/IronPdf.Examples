using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section1
    {
        public void Run()
        {
            // Import cover page
            PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");
            
            // Import content document
            PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");
            
            // Merge the two documents
            PdfDocument finalPdf = PdfDocument.Merge(coverPage, contentPage);
            
            finalPdf.SaveAs("pdfWithCover.pdf");
        }
    }
}