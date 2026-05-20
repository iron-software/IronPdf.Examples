***Based on <https://ironpdf.com/examples/generate-pdfs-with-default-parameters/>***

The flagship feature of IronPDF is its ability to convert HTML into PDFs while retaining the original layouts and styles. This functionality is essential for creating PDFs from web content for various uses such as reports, invoices, and documentation. Users can convert HTML files, URLs, and HTML strings directly into PDF documents. For more details, explore our comprehensive guide on [HTML to PDF Conversion](https://ironpdf.com/tutorials/html-to-pdf/).

Below is a C# code example demonstrating how to use IronPDF to perform HTML to PDF conversions:

```csharp
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate a new ChromePdfRenderer
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Convert an HTML string to PDF
        string htmlString = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from an HTML string.</p>";
        // Convert and render the HTML string into a PDF
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        // Save the PDF file
        pdfDocumentFromString.SaveAs("FromHtmlStringToPDF.pdf");

        // 2. Convert an HTML file to PDF
        string pathToHtmlFile = "your_html_file_path.html"; // Update the path of your HTML file
        // Convert and render the HTML file to a PDF
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(pathToHtmlFile);
        // Save the new PDF document
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // 3. Convert a web page URL to PDF
        string websiteUrl = "http://ironpdf.com"; // Define the URL to convert
        // Convert and render the URL to a PDF document
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        // Save the PDF file generated
        pdfDocumentFromUrl.SaveAs("FromURLToPDF.pdf");
    }
}
```

This C# example illustrates three primary operations: converting an HTML string, an HTML file, and a web page URL into PDF documents using IronPDF's `ChromePdfRenderer`. Each operation involves rendering the content and saving it as a PDF file with a specific name, demonstrating the versatility and ease of use of IronPDF for .NET developers.