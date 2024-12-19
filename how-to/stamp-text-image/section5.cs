using IronPdf.Editing;
using IronPdf;
namespace IronPdf.Examples.HowTo.StampTextImage
{
    public static class Section5
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");
            
            // Create HTML stamper
            HtmlStamper htmlStamper = new HtmlStamper()
            {
                Html = @"<img src='https://ironpdf.com/img/svgs/iron-pdf-logo.svg'>
                <h1>Iron Software</h1>",
                VerticalAlignment = VerticalAlignment.Top,
            };
            
            // Stamp the HTML stamper
            pdf.ApplyStamp(htmlStamper);
            
            pdf.SaveAs("stampHtml.pdf");
        }
    }
}