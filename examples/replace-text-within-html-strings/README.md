***Based on <https://ironpdf.com/examples/replace-text-within-html-strings/>***

IronPDF's standout feature, the [HTML to PDF conversion tutorials](https://ironpdf.com/tutorials/html-to-pdf/), maintains layouts and styles effectively. This capability enables the creation of PDF documents from web content such as reports, invoices, and documentation. IronPDF supports converting HTML files, URLs, and HTML strings directly into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Convert HTML String to PDF
        var htmlCode = "<h1>Welcome to IronPDF!</h1><p>Generate a PDF from an HTML string.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlCode);
        pdfDocumentFromString.SaveAs("ConvertedFromHTMLString.pdf");

        // 2. Convert HTML File to PDF
        var filePathToHtml = "your_html_file_path.html"; // Define your HTML file path
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePathToHtml);
        pdfDocumentFromFile.SaveAs("ConvertedFromHTMLFile.pdf");

        // 3. Convert URL to PDF
        var targetUrl = "https://ironpdf.com"; // Define the target URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(targetUrl);
        pdfDocumentFromUrl.SaveAs("ConvertedFromURL.pdf");
    }
}
```

In this code example, IronPDF is utilized to convert HTML content into PDF files in three ways: from an HTML string, from a local HTML file, and from a webpage via URL. The examples demonstrate how to initialize a `ChromePdfRenderer`, create PDFs using different sources, and save them with new filenames.