using IronPdf;
namespace IronPdf.Examples.HowTo.AddPdfOutlineBookmarks
{
    public static class Section3
    {
        public static void Run()
        {
            /**
            Extract and Search Text
            anchor-extract-and-search-text-images
            **/
            
            using IronPdf;
            
            // Create a new PDF or edit an existing document
            PdfDocument PDF = PdfDocument.FromFile("file.pdf");
            
            // Extract text from all pages of PDF document
            string AllText = PDF.ExtractAllText();
            
            for (var index = 0; index < PDF.PageCount; index++)
            {
                int PageNumber = index + 1;
            
                // Extract text from specified page
                string Text = PDF.ExtractTextFromPage(index);
            
                //Search here!
            }
        }
    }
}