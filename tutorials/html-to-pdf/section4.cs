using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section4
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // Convert HTML content with local image and CSS references
            string html = @"
                <link rel='stylesheet' href='styles.css'>
                <img src='logo.png' alt='Company Logo'>
                <h1>Company Report</h1>
                <p>Annual report content...</p>";
            
            // Set base path for resolving relative URLs in HTML to PDF conversion
            var pdf = renderer.RenderHtmlAsPdf(html, @"C:\MyProject\Assets\");
            pdf.SaveAs("report.pdf");
        }
    }
}