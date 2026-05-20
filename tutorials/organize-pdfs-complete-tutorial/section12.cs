using IronPdf;
namespace IronPdf.Examples.Tutorial.OrganizePdfsCompleteTutorial
{
    public static class Section12
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