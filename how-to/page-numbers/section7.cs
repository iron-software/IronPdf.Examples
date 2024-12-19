using IronPdf;
namespace IronPdf.Examples.HowTo.PageNumbers
{
    public static class Section7
    {
        public static void Run()
        {
            // First page only
            var firstPageIndex = new List<int>() { 0 };
            
            pdf.AddHtmlHeaders(header, 1, firstPageIndex);
            pdf.SaveAs("FirstPageOnly.pdf");
        }
    }
}