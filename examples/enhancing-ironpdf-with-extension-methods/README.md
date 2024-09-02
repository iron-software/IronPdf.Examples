IronPDF's premier functionality is the [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/) conversion, which seamlessly maintains the original layouts and styles. This feature allows for the generation of PDF documents from web content, including reports, invoices, and documentation. IronPDF is adept at transforming HTML files, URLs, and HTML strings into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transforming an HTML String into a PDF
        var htmlCode = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string into a PDF format.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlCode);
        pdfDocumentFromString.SaveAs("FromStringToPDF.pdf");

        // 2. Converting an HTML File to PDF
        var htmlFileLocation = "your_html_file_path.html"; // Update with the path to the HTML file
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFileLocation);
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // 3. Creating a PDF from a URL
        var websiteUrl = "http://ironpdf.com"; // Define the URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```

In this rewritten code, the C# `ChromePdfRenderer` class is utilized to convert HTML directly into PDFs, illustrating three common scenarios: converting raw HTML strings, local HTML files, and web pages identified by URLs, each saved to distinct PDF files.