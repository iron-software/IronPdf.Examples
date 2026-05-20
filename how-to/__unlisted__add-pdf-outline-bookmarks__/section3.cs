using IronPdf;
namespace IronPdf.Examples.HowTo.__Unlisted__AddPdfOutlineBookmarks__
{
    public static class Section3
    {
        public static void Run()
        {
            /**
             * Extract and Search Text
             * anchor-extract-and-search-text-images
             **/
            
            using IronPdf;
            
            // Create a new PDF or edit an existing document
            PdfDocument pdf = PdfDocument.FromFile("file.pdf");
            
            // Extract text from all pages of PDF document
            string allText = pdf.ExtractAllText();
            
            for (var index = 0; index < pdf.PageCount; index++)
            {
                int pageNumber = index + 1;
            
                // Extract text from specified page
                string text = pdf.ExtractTextFromPage(index);
            
                // Implement your searching logic here, such as using .NET string methods
            }
        }
    }
}