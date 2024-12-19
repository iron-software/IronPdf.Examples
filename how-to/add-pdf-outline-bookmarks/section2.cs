using IronPdf;
namespace IronPdf.Examples.HowTo.AddPdfOutlineBookmarks
{
    public static class Section2
    {
        public static void Run()
        {
            /**
            Add Outline Bookmark
            anchor-add-outlines-bookmarks
            **/
            
            using IronPdf;
            
            // Create a new PDF or edit an existing document
            PdfDocument pdf = PdfDocument.FromFile("examination.pdf");
            
            // Assign IPdfBookMark object to a variable
            var mainBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Examination", 0);
            
            // Add bookmark for days
            var date1Bookmark = mainBookmark.Children.AddBookMarkAtStart("Date1", 1);
            
            // Add bookmark for type of test
            var paperBookmark = date1Bookmark.Children.AddBookMarkAtStart("Paper", 1);
            paperBookmark.Children.AddBookMarkAtStart("PersonA", 3);
            paperBookmark.Children.AddBookMarkAtStart("PersonB", 4);
            
            // Add bookmark for days
            var date2Bookmark = mainBookmark.Children.AddBookMarkAtEnd("Date2", 5);
            
            // Add bookmark for type of test
            var computerBookmark = date2Bookmark.Children.AddBookMarkAtStart("Computer", 5);
            computerBookmark.Children.AddBookMarkAtStart("PersonC", 6);
            computerBookmark.Children.AddBookMarkAtStart("PersonD", 7);
        }
    }
}