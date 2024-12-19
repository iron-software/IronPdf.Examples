using IronPdf;
namespace IronPdf.Examples.HowTo.HeadersAndFooters
{
    public static class Section9
    {
        public static void Run()
        {
            // Add to PDF
            pdf.AddHtmlHeaders(header, 0, 0, 0);
            pdf.AddHtmlFooters(footer, 0, 0, 0);
        }
    }
}