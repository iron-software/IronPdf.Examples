***Based on <https://ironpdf.com/examples/extract-all-text-from-pdfs/>***

IronPDF excels at [converting HTML to PDF while maintaining the original layout and styles](https://ironpdf.com/tutorials/html-to-pdf/). This powerful feature enables the creation of PDF documents from web content, such as reports, invoices, and other types of documentation. It supports the conversion of HTML from local files, URLs, and direct HTML strings into professionally formatted PDF files.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. HTML string to PDF conversion
        var htmlString = "<h1>Greetings from IronPDF!</h1><p>Generating a PDF from an HTML string.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocumentFromString.SaveAs("FromStringToPDF.pdf");

        // 2. HTML file to PDF conversion
        var filePath = "your_html_file_path.html"; // Define the path to your HTML file
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // 3. Web URL to PDF conversion
        var websiteUrl = "https://ironpdf.com"; // Define the URL to convert
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```
This concise code snippet demonstrates the process of converting HTML content into PDF files using IronPDF's `ChromePdfRenderer` class. Each section of the code efficiently handles different sources of HTML, whether it be a string, a local file, or a webpage, showcasing IronPDF's versatility in generating high-quality PDF documents.