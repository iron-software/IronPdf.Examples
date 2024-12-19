using IronPdf;
namespace IronPdf.Examples.HowTo.AddCopyDeletePagesPdf
{
    public static class Section2
    {
        public static void Run()
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