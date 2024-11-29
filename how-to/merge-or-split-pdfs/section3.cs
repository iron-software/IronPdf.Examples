using IronPdf;
namespace ironpdf.MergeOrSplitPdfs
{
    public class Section3
    {
        public void Run()
        {
            // We will use the 4-page PDF from the Merge example above:
            var pdf = PdfDocument.FromFile("Merged.pdf");
            
            // Takes only the first page into a new PDF
            var page1doc = pdf.CopyPage(0);
            page1doc.SaveAs("Page1Only.pdf");
            
            // Take the pages 2 & 3 (Note: index starts at 0)
            var page23doc = pdf.CopyPages(1, 2);
            page23doc.SaveAs("Pages2to3.pdf");
        }
    }
}