using IronPdf;
namespace IronPdf.Examples.HowTo.Bookmarks
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Add PDF Bookmarks Instantly
            var pdf = new IronPdf.PdfDocument("example.pdf");
            pdf.Bookmarks.AddBookMarkAtEnd("Chapter 1", 1);
            pdf.SaveAs("bookmarked.pdf");
        }
    }
}