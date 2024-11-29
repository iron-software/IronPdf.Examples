using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section6
    {
        public void Run()
        {
            // Last page only
            var lastPageIndex = new List<int>() { pdf.PageCount - 1 };
            
            pdf.AddHtmlHeaders(header, 1, lastPageIndex);
            pdf.SaveAs("LastPageOnly.pdf");
        }
    }
}