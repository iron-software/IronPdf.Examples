using IronPdf;
namespace IronPdf.Examples.HowTo.__Unlisted__AddPdfOutlineBookmarks__
{
    public static class Section2
    {
        public static void Run()
        {
            /**
             * Add Outline Bookmark
             * anchor-add-outlines-bookmarks
             **/
            
            using IronPdf;
            
            // Create a new PDF or edit an existing document
            PdfDocument pdf = PdfDocument.FromFile("examination.pdf");
            
            // Create a main bookmark and add children bookmarks
            var mainBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Examination", 0);
            
            var date1Bookmark = mainBookmark.Children.AddBookMarkAtStart("Date1", 1);
            var paperBookmark = date1Bookmark.Children.AddBookMarkAtStart("Paper", 1);
            paperBookmark.Children.AddBookMarkAtStart("PersonA", 3);
            paperBookmark.Children.AddBookMarkAtStart("PersonB", 4);
            
            var date2Bookmark = mainBookmark.Children.AddBookMarkAtEnd("Date2", 5);
            var computerBookmark = date2Bookmark.Children.AddBookMarkAtStart("Computer", 5);
            computerBookmark.Children.AddBookMarkAtStart("PersonC", 6);
            computerBookmark.Children.AddBookMarkAtStart("PersonD", 7);
        }
    }
}