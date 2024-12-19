using IronPdf;
namespace IronPdf.Examples.HowTo.HeadersAndFooters
{
    public static class Section8
    {
        public static void Run()
        {
            string headerHtml = @"
                <html>
                <head>
                    <link rel='stylesheet' href='style.css'>
                </head>
                <body>
                    <h1>This is a header!</h1>
                </body>
                </html>";
            
            string footerHtml = @"
                <html>
                <head>
                    <link rel='stylesheet' href='style.css'>
                </head>
                <body>
                    <h1>This is a footer!</h1>
                </body>
                </html>";
            
            // Instantiate renderer and create PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            
            // Create header and footer
            HtmlHeaderFooter htmlHeader = new HtmlHeaderFooter
            {
                HtmlFragment = headerHtml,
                LoadStylesAndCSSFromMainHtmlDocument = true,
            };
            
            HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter
            {
                HtmlFragment = footerHtml,
                LoadStylesAndCSSFromMainHtmlDocument = true,
            };
            
            // Add to PDF
            pdf.AddHtmlHeaders(htmlHeader);
            pdf.AddHtmlFooters(htmlFooter);
        }
    }
}