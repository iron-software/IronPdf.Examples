using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section2
    {
        public void Run()
        {
            // Import cover page
            PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");
            
            // Import content document
            PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");
            
            // Insert PDF
            contentPage.InsertPdf(coverPage, 0);
        }
    }
}