using IronPdf;

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

// Instantiate renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Create header and footer and add to rendering options
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter
{
    HtmlFragment = headerHtml,
    LoadStylesAndCSSFromMainHtmlDocument = true,
};

renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = footerHtml,
    LoadStylesAndCSSFromMainHtmlDocument = true,
};

// Render PDF with header and footer
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");