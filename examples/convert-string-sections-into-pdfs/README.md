***Based on <https://ironpdf.com/examples/convert-string-sections-into-pdfs/>***

IronPDF's standout functionality is its [HTML to PDF conversion capabilities](https://ironpdf.com/tutorials/html-to-pdf/), which adeptly maintain the original layout and styles. This feature excels in creating PDFs from various web contents such as reports, invoices, and documentation. It adeptly handles the conversion of HTML files, URLs, and HTML strings into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Convert an HTML String to PDF
        var htmlCode = "<h1>Welcome to IronPDF!</h1><p>Create a PDF from this HTML string.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlCode);
        pdfDocumentFromString.SaveAs("FromStringToPDF.pdf");

        // 2. Convert an HTML File to PDF
        var filePath = "your_html_file_path.html"; // Provide the path to your HTML file
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // 3. Convert a Web URL to PDF
        var webUrl = "https://ironpdf.com"; // Provide the URL that points to your target website
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(webUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```

By utilizing IronPDF, developers can efficiently transform HTML content into high-fidelity PDF files using concise and straightforward code examples, covering a range of sources from strings and local files to web URLs.