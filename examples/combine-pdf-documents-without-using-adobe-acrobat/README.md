> Docs: [IronPDF documentation](https://ironpdf.com/docs/)

IronPDF's primary capability is the [HTML to PDF Conversion Tutorial](https://ironpdf.com/tutorials/html-to-pdf/), which efficiently retains the original layouts and styling. This feature is invaluable for creating PDF documents from web content like reports, invoices, and manuals. It adeptly handles the conversion of HTML documents, web URLs, and HTML strings directly into PDF files.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the PDF converter
        var pdfConverter = new ChromePdfRenderer();

        // Example 1: Converting an HTML String to a PDF document
        // Create an HTML string
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>Generating a PDF from an HTML string.</p>";
        
        // Convert the HTML string to PDF
        var pdfDocumentFromString = pdfConverter.RenderHtmlAsPdf(htmlString);

        // Save the PDF to a local file
        pdfDocumentFromString.SaveAs("FromHtmlStringToPDF.pdf");

        // Example 2: Converting an HTML file to a PDF document
        // Define the path to the HTML file
        var filePath = "your_html_file_path.html";
        
        // Convert the HTML file to PDF
        var pdfDocumentFromFile = pdfConverter.RenderHtmlFileAsPdf(filePath);

        // Save the PDF to a local file
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // Example 3: Converting a Web URL to a PDF document
        // Provide the URL to convert
        var websiteUrl = "https://ironpdf.com";
        
        // Convert the URL to PDF
        var pdfDocumentFromUrl = pdfConverter.RenderUrlAsPdf(websiteUrl);

        // Save the PDF to a local file
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```

In this revised example, the code is refactored to improve clarity, with distinct sections that are commented to guide the user through each step of converting HTML content into PDF format. The comments are designed to give a clear understanding of what each block of the script does, facilitating easier adaptation and maintenance.