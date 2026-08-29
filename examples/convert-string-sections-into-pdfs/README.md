> Docs: [IronPDF documentation](https://ironpdf.com/docs/)

IronPDF stands out with its [HTML to PDF conversion features](https://ironpdf.com/tutorials/html-to-pdf/), which effectively maintain the original styles and layouts. This functionality allows for the creation of PDFs from diverse web content, including reports, invoices, and various kinds of documentation. It provides options to convert HTML documents, web URLs, and HTML strings directly into PDF formats.

```csharp
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var renderer = new ChromePdfRenderer();

        // 1. Transform HTML String into PDF
        // Define the HTML content for PDF conversion
        var htmlContent = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from this HTML code.</p>";
        // Convert HTML string into a PDF document
        var pdfDocumentFromHtml = renderer.RenderHtmlAsPdf(htmlContent);
        // Save the PDF document to the filesystem
        pdfDocumentFromHtml.SaveAs("ConvertedHtmlStringToPDF.pdf");

        // 2. Transform HTML File into PDF
        // Give the path to the HTML file you want to transform
        var htmlFilePath = "your_html_file_path.html";
        // Convert the HTML file into a PDF document
        var pdfDocumentFromFile = renderer.RenderHtmlFileAsPdf(htmlFilePath);
        // Save this PDF document
        pdfDocumentFromFile.SaveAs("ConvertedHtmlFileToPDF.pdf");

        // 3. Transform URL into PDF
        // Indicate the URL you wish to convert into a PDF document
        var webpageUrl = "https://ironpdf.com";
        // Convert the given URL to a PDF
        var pdfFromWebPage = renderer.RenderUrlAsPdf(webpageUrl);
        // Save the URL-based PDF locally
        pdfFromWebPage.SaveAs("WebUrlToPDF.pdf");
    }
}
```

This code snippet illustrates three common scenarios: converting a simple HTML string to a PDF, converting an HTML file located on your system to a PDF, and converting a webpage into a PDF document.