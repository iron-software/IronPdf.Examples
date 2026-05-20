using IronPdf;
namespace IronPdf.Examples.HowTo.MergeOrSplitPdfs
{
    public static class Section3
    {
        public static void Run()
        {
            // Load an existing PDF document from a file.
            PdfDocument pdf = PdfDocument.FromFile("Merged.pdf");
            
            // Combine pages of the loaded PDF into a grid with specified dimensions.
            // The parameters for CombinePages are the width and height of each page
            // in millimeters followed by the number of rows and columns to create the grid.
            int pageWidth = 250;  // Width of each page in the grid
            int pageHeight = 250; // Height of each page in the grid
            int rows = 2;         // Number of rows in the grid
            int columns = 2;      // Number of columns in the grid
            
            // Combine the pages of the PDF document into a single page with specified dimensions.
            PdfDocument combinedPages = pdf.CombinePages(pageWidth, pageHeight, rows, columns);
            
            // Save the combined document as a new PDF file.
            combinedPages.SaveAs("combinedPages.pdf");
        }
    }
}