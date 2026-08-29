> Docs: [IronPDF documentation](https://ironpdf.com/docs/)

IronPDF excels at [converting HTML content into PDF documents](https://ironpdf.com/tutorials/html-to-pdf/), while also maintaining the original layouts and styles. This functionality is essential for creating PDF versions of web content like reports, invoices, and various forms of documentation. IronPDF handles the conversion of HTML files, URLs, and HTML strings into PDF formats with ease.

```csharp
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the ChromePdfRenderer from IronPdf.
        var pdfRenderer = new ChromePdfRenderer();
        
        // Example 1: Converting an HTML String to a PDF
        // Assign the HTML content to a string variable.
        var htmlCode = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML to a PDF document.</p>";
        
        // Convert the HTML string into a PDF file.
        var pdfDocumentFromHtml = pdfRenderer.RenderHtmlAsPdf(htmlCode);
        
        // Save the created PDF to the system.
        pdfDocumentFromHtml.SaveAs("ConvertedFromHTMLString.pdf");

        // Example 2: Converting an HTML File to a PDF
        // Provide the path to the HTML file.
        var filePath = "your_html_file_path.html"; // Modify this with your actual HTML file path.
        
        // Convert the HTML file to a PDF document.
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        
        // Store the resulting PDF file.
        pdfDocumentFromFile.SaveAs("ConvertedFromHTMLFile.pdf");

        // Example 3: Converting a Web URL to a PDF
        // Define the URL for conversion.
        var websiteUrl = "http://ironpdf.com"; // Update this to the URL you wish to convert.
        
        // Convert the specified URL to a PDF file.
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        
        // Save the PDF file generated from the URL.
        pdfDocumentFromUrl.SaveAs("ConvertedFromURL.pdf");
    }
}
```

The code above transforms HTML data directly into structured PDF files, preserving the styling of the original content. The examples provided show different use cases for converting HTML strings, files, and URLs into PDF documents.