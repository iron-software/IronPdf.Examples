using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section7
    {
        public void Run()
        {
            // Create header and footer
            TextHeaderFooter textHeader = new TextHeaderFooter
            {
                CenterText = "{page} of {total-pages}",
                LeftText = "Today's date: {date}",
                RightText = "The time: {time}",
            };
            
            TextHeaderFooter textFooter = new TextHeaderFooter
            {
                CenterText = "Current URL: {url}",
                LeftText = "Title of the HTML: {html-title}",
                RightText = "Title of the PDF: {pdf-title}",
            };
        }
    }
}