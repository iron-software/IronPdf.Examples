IronPDF's standout feature is converting HTML to PDF, which it does while maintaining the original layout and styles. This functionality is perfect for creating PDF versions of web contents such as reports, invoices, and documentation. IronPDF adeptly handles HTML files, URLs, and HTML strings, transforming them into professional-quality PDF documents. [Learn more about HTML to PDF conversion here](https://ironpdf.com/tutorials/html-to-pdf/).

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // Example 1: Transform HTML string to PDF
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>Generating a PDF from an HTML string.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocumentFromString.SaveAs("FromHtmlStringToPdf.pdf");

        // Example 2: Convert HTML file to PDF
        var htmlFileLocation = "path_to_your_html_file.html"; // Update with your HTML file path
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFileLocation);
        pdfDocumentFromFile.SaveAs("FromHtmlFileToPdf.pdf");

        // Example 3: Converting a URL to PDF
        var targetUrl = "http://ironpdf.com"; // The URL to be converted
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(targetUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPdf.pdf");
    }
}
```

This example showcases the different ways you can use IronPDF to create PDFs from HTML content, including directly from an HTML string, an HTML file, or even a URL, each undergoing seamless conversion to create ready-to-use PDF files.