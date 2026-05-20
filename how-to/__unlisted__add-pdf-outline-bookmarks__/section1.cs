using IronPdf;
namespace IronPdf.Examples.HowTo.__Unlisted__AddPdfOutlineBookmarks__
{
    public static class Section1
    {
        public static void Run()
        {
            /**
             * Add Outline Bookmark
             * anchor-add-outlines-bookmarks
             **/
            
            using IronPdf;
            
            // Create a new PDF or edit an existing document
            using PdfDocument pdf = PdfDocument.FromFile("existing.pdf");
            
            // Add a bookmark at the end of the document
            pdf.Bookmarks.AddBookMarkAtEnd("NameOfBookmark", 0);
            
            // Add a sub-bookmark within the previous bookmark
            pdf.Bookmarks.AddBookMarkAtEnd("NameOfSubBookmark", 1);
        }
    }
}