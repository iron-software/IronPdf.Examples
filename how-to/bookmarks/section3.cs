using IronPdf;
namespace ironpdf.Bookmarks
{
    public class Section3
    {
        public void Run()
        {
            // Load existing PDF document
            PdfDocument pdf = PdfDocument.FromFile("multiLayerBookmarks.pdf");
            
            // Retrieve bookmarks list
            var mainBookmark = pdf.Bookmarks.GetAllBookmarks();
        }
    }
}