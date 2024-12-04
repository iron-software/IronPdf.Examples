***Based on <https://ironpdf.com/examples/convert-string-sections-into-pdfs/>***

IronPDF's standout capability is its [HTML to PDF conversion features](https://ironpdf.com/tutorials/html-to-pdf/), which not only convert but also maintain the original layout and styling. This functionality allows for the creation of PDFs from various web content including reports, invoices, and documentation. It adeptly handles conversions from HTML files, URLs, and HTML strings into PDF documents.

```cs
using IronPdf;

class ExampleConversion
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // Converting an HTML string to a PDF document
        string htmlSource = "<h1>Welcome to IronPDF!</h1><p>Generating PDF from an HTML string.</p>";
        var resultFromHtml = pdfRenderer.RenderHtmlAsPdf(htmlSource);
        resultFromHtml.SaveAs("ConvertedFromHTMLString.pdf");

        // Converting an HTML file to a PDF document
        string filePath = "your_filename.html";  // Provide your HTML file path
        var resultFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        resultFromFile.SaveAs("ConvertedFromHTMLFile.pdf");

        // Converting a web URL to a PDF document
        string webpageUrl = "https://ironpdf.com";  // Define the webpage URL here
        var resultFromUrl = pdfRenderer.RenderUrlAsPdf(webpageUrl);
        resultFromUrl.SaveAs("ConvertedFromURL.pdf");
    }
}
```

This example demonstrates using IronPDF to convert HTML sources, whether they are strings, local files, or URLs, into PDF documents, each preserving the essence and design of the original HTML content.