using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section7
    {
        public void Run()
        {
            // First page only
            var firstPageIndex = new List<int>() { 0 };
            
            pdf.AddHtmlHeaders(header, 1, firstPageIndex);
            pdf.SaveAs("FirstPageOnly.pdf");
        }
    }
}