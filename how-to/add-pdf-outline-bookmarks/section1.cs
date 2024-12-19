using IronPdf;
namespace IronPdf.Examples.HowTo.AddPdfOutlineBookmarks
{
    public static class Section1
    {
        public static void Run()
        {
            /**
            Add Outline Bookmark
            anchor-add-outlines-bookmarks
            **/
            
            using IronPdf;
            
            // Create a new PDF or edit an existing document
            using PdfDocument pdf = PdfDocument.FromFile("existing.pdf");
            
            // Add a bookmark
            pdf.Bookmarks.AddBookMarkAtEnd("NameOfBookmark", 0);
            
            // Add a sub-bookmark within the previous
            pdf.Bookmarks.AddBookMarkAtEnd("NameOfSubBookmark", 1);
        }
    }
}