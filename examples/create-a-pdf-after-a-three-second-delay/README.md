IronPDF excels in converting HTML to PDF while maintaining original layouts and styles. This capability is perfect for creating PDF reports, invoices, and documentation directly from web content including HTML files, URLs, and HTML strings.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform an HTML string into a PDF
        var htmlSample = "<h1>Welcome to IronPDF!</h1><p>Generating a PDF from an HTML string.</p>";
        var pdfFromHtml = pdfRenderer.RenderHtmlAsPdf(htmlSample);
        pdfFromHtml.SaveAs("FromHtmlStringToPDF.pdf");

        // 2. Turn an HTML File into PDF
        var pathToHtml = "path_to_your_html_file.html"; // Update with your HTML file's path
        var pdfFromFile = pdfRenderer.RenderHtmlFileAsPdf(pathToHtml);
        pdfFromFile.SaveAs("FromHtmlFileToPDF.pdf");

        // 3. Convert a webpage to PDF
        var webpageUrl = "http://ironpdf.com"; // Enter the webpage URL
        var pdfFromWebpage = pdfRenderer.RenderUrlAsPdf(webpageUrl);
        pdfFromWebpage.SaveAs("FromUrlToPDF.pdf");
    }
}
```

In the provided code, IronPDF’s `ChromePdfRenderer` is utilized to generate PDFs from different HTML sources. First, it manages HTML strings, then local HTML files, and finally, it takes URLs and transforms them into PDF files, demonstrating the flexibility and power of IronPDF for various PDF conversion needs.