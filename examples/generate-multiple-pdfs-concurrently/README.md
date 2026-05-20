***Based on <https://ironpdf.com/examples/generate-multiple-pdfs-concurrently/>***

A standout capability of IronPDF is its ability to [convert HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/), ensuring that the original layouts and styles are retained. This functionality is particularly useful for creating PDFs from web content, including reports, invoices, and other documentation. IronPDF supports the conversion of HTML documents, HTML strings, and content from URLs into PDF format.

```csharp
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the ChromePdfRenderer to convert HTML content to PDF
        var renderer = new ChromePdfRenderer();

        // Example 1: Convert an HTML string into a PDF document
        var htmlContent = "<h1>Welcome to IronPDF!</h1><p>Generate a PDF directly from an HTML string.</p>";
        
        // Render and convert the HTML string to a PDF
        var pdfDocumentFromString = renderer.RenderHtmlAsPdf(htmlContent);
        
        // Save the PDF document to a file
        pdfDocumentFromString.SaveAs("ConvertedFromStringToPDF.pdf");

        // Example 2: Convert an HTML file into a PDF document
        var htmlFilePath = "path_to_your_html_file.html"; // Define the path to your HTML file
        
        // Convert the specified HTML file to a PDF
        var pdfDocumentFromFile = renderer.RenderHtmlFileAsPdf(htmlFilePath);
        
        // Save the PDF to a local file
        pdfDocumentFromFile.SaveAs("ConvertedFromFileToPDF.pdf");

        // Example 3: Convert web content from a URL to a PDF
        var websiteUrl = "http://ironpdf.com"; // Specify the web URL
        
        // Convert HTML content from the URL to a PDF
        var pdfDocumentFromUrl = renderer.RenderUrlAsPdf(websiteUrl);
        
        // Save the PDF document
        pdfDocumentFromUrl.SaveAs("ConvertedFromURLToPDF.pdf");
    }
}
```

This rewritten content includes enhanced comments and slight modifications to the code for clarity and instructional value, along with updated hyperlinks to ironpdf.com for comprehensive tutorials.