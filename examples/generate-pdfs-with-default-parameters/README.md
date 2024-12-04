***Based on <https://ironpdf.com/examples/generate-pdfs-with-default-parameters/>***

One of the primary features of IronPDF is its ability to convert HTML to PDF, capturing the layouts and styles perfectly. This functionality is excellent for generating PDFs from web content such as reports, invoices, and documentation. It effectively handles the conversion of HTML files, URLs, and HTML strings into PDF documents. For more details, visit the [HTML to PDF Conversion](https://ironpdf.com/tutorials/html-to-pdf/) guide.

Here’s an example of how to use IronPDF to convert HTML content to PDF in C#:

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // Convert an HTML string to a PDF
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>Generating a PDF from an HTML string.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocumentFromString.SaveAs("FromStringToPDF.pdf");

        // Convert an HTML file to a PDF
        var filePath = "your_html_file_path.html"; // Provide the path to your HTML file
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // Convert a web URL to a PDF
        var webpageUrl = "https://ironpdf.com"; // Provide the URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(webpageUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```

In this updated code, we've defined the steps to transform HTML string, file, and webpage into PDF documents using IronPDF's `ChromePdfRenderer`. Each section provides a straightforward example of implementing the conversion, making it easy to adapt for various uses such as creating digital reports or archiving web content.