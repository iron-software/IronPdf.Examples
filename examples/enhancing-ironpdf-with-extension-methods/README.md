***Based on <https://ironpdf.com/examples/enhancing-ironpdf-with-extension-methods/>***

IronPDF's standout capability is its [conversion of HTML to PDF while retaining layout](https://ironpdf.com/tutorials/html-to-pdf/), ensuring that both the layouts and styles are preserved. This feature is particularly useful for creating PDFs from web content, including reports, invoices, and documentation. IronPDF supports the conversion of HTML documents, URLs, and HTML strings directly into PDF files.

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform HTML String to PDF
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>This PDF was created from an HTML string.</p>";
        var pdfDocumentFromHtmlString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocumentFromHtmlString.SaveAs("FromHtmlStringToPDF.pdf");

        // 2. Transform HTML File to PDF
        var pathToHtmlFile = "path_to_your_html_file.html"; // Define the path to your HTML file
        var pdfDocumentFromHtmlFile = pdfRenderer.RenderHtmlFileAsPdf(pathToHtmlFile);
        pdfDocumentFromHtmlFile.SaveAs("FromHtmlFileToPDF.pdf");

        // 3. Transform URL to PDF
        var webUrl = "http://ironpdf.com"; // Define the URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(webUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```

In the provided C# script, IronPDF's `ChromePdfRenderer` is employed to convert HTML content into high-quality PDF documents in a few different ways. This includes rendering directly from HTML strings, local HTML files, and web URLs. The resulting PDF files are then saved with descriptive names, illustrating the source from which they were generated.