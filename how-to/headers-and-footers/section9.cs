using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section9
    {
        public void Run()
        {
            // Add to PDF
            pdf.AddHtmlHeaders(header, 0, 0, 0);
            pdf.AddHtmlFooters(footer, 0, 0, 0);
        }
    }
}