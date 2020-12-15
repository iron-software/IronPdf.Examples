using IronPdf;
using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class OutlinesBookmarks : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf

            // create a new PDF or edit an existing document.
            PdfDocument Pdf = PdfDocument.FromFile(@"Inputs\PDFToImages.pdf");
            // Add a bookmark
            Pdf.BookMarks.AddBookMarkAtEnd("Summary", 17, 0);
            // Add a sub-bookmark within the summary
            Pdf.BookMarks.AddBookMarkAtEnd("Conclusion", 17, 1);
            //delete an old Bookmark
            Pdf.BookMarks.RemoveBookMarkAt(0);
            Pdf.SaveAs($@"{OutputPath}\OutlinesBookmarks.pdf");
        }
    }
}
