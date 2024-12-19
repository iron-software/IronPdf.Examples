using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section4
    {
        public static void Run()
        {
            // Get even page indexes (resulting in odd page numbers)
            var evenPageIndices = allPageIndices.Where(i => i % 2 == 0);
            
            pdf.AddHtmlHeaders(header, 1, evenPageIndices);
            pdf.SaveAs("EvenPages.pdf");
        }
    }
}