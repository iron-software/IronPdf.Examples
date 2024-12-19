using IronPdf;
namespace IronPdf.Examples.HowTo.Bookmarks
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new PDF or edit an existing document.
            PdfDocument pdf = PdfDocument.FromFile("existing.pdf");
            
            // Add a bookmark
            pdf.Bookmarks.AddBookMarkAtEnd("NameOfBookmark", 0);
            
            // Add a sub-bookmark
            pdf.Bookmarks.AddBookMarkAtEnd("NameOfSubBookmark", 1);
            
            pdf.SaveAs("singleLayerBookmarks.pdf");
        }
    }
}