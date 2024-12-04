using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section5
    {
        public void Run()
        {
            // Get odd page indexes (resulting in even page numbers)
            var oddPageIndexes = allPageIndices.Where(i => i % 2 != 0);
            
            pdf.AddHtmlHeaders(header, 1, oddPageIndexes);
            pdf.SaveAs("OddPages.pdf");
        }
    }
}