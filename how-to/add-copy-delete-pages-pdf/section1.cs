using IronPdf;
namespace IronPdf.Examples.HowTo.AddCopyDeletePagesPdf
{
    public static class Section1
    {
        public static void Run()
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