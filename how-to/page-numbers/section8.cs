using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section8
    {
        public void Run()
        {
            // Skip the first page
            var skipFirstPage = allPageIndices.Skip(1);
            
            pdf.AddHtmlHeaders(header, 1, skipFirstPage);
            pdf.SaveAs("SkipFirstPage.pdf");
        }
    }
}