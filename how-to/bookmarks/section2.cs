using IronPdf;
namespace ironpdf.Bookmarks
{
    public class Section2
    {
        public void Run()
        {
            // Load existing PDF document
            PdfDocument pdf = PdfDocument.FromFile("examinationPaper.pdf");
            
            // Assign IPdfBookMark object to a variable
            var mainBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Examination", 0);
            
            // Add bookmark for days
            var date1Bookmark = mainBookmark.Children.AddBookMarkAtStart("Date1", 1);
            
            // Add bookmark for type of test
            var paperBookmark = date1Bookmark.Children.AddBookMarkAtStart("Paper", 1);
            paperBookmark.Children.AddBookMarkAtEnd("PersonA", 3);
            paperBookmark.Children.AddBookMarkAtEnd("PersonB", 4);
            
            // Add bookmark for days
            var date2Bookmark = mainBookmark.Children.AddBookMarkAtEnd("Date2", 5);
            
            // Add bookmark for type of test
            var computerBookmark = date2Bookmark.Children.AddBookMarkAtStart("Computer", 5);
            computerBookmark.Children.AddBookMarkAtEnd("PersonC", 6);
            computerBookmark.Children.AddBookMarkAtEnd("PersonD", 7);
            
            pdf.SaveAs("multiLayerBookmarks.pdf");
        }
    }
}