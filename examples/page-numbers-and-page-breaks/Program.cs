using IronPdf;

var html = @"
    <p> Hello Iron</p>
    <p> This is 1st Page </p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 2nd Page</p>
    <div style = 'page-break-after: always;' ></div>
    <p> This is 3rd Page</p>";

// Instantiate Renderer
var renderer = new ChromePdfRenderer
{
    RenderingOptions =
    {
        HtmlFooter = new HtmlHeaderFooter()
        {

            MaxHeight = 15, // millimeters
            HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
            DrawDividerLine = true
        }
    }
};

var pdf = renderer.RenderHtmlAsPdf(html);
pdf.SaveAs("pageNumber.pdf");
