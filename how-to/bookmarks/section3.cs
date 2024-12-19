using IronPdf;
namespace IronPdf.Examples.HowTo.Bookmarks
{
    public static class Section3
    {
        public static void Run()
        {
            // Load existing PDF document
            PdfDocument pdf = PdfDocument.FromFile("multiLayerBookmarks.pdf");
            
            // Retrieve bookmarks list
            var mainBookmark = pdf.Bookmarks.GetAllBookmarks();
        }
    }
}