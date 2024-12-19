using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section5
    {
        public static void Run()
        {
            // Get odd page indexes (resulting in even page numbers)
            var oddPageIndexes = allPageIndices.Where(i => i % 2 != 0);
            
            pdf.AddHtmlHeaders(header, 1, oddPageIndexes);
            pdf.SaveAs("OddPages.pdf");
        }
    }
}