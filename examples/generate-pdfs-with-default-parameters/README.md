IronPDF's hallmark feature is [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/), which is adept at preserving both layouts and styles. This functionality allows for the creation of PDFs from web content including reports, invoices, and documents. IronPDF supports transforming HTML files, URLs, and HTML Strings directly into PDF files.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform HTML string to PDF
        var htmlText = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string into a PDF document.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlText);
        pdfDocumentFromString.SaveAs("FromStringToPDF.pdf");

        // 2. Transform HTML file to PDF
        var pathToHtmlFile = "path_to_your_html_file.html"; // Update with the path to your HTML file
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(pathToHtmlFile);
        pdfDocumentFromFile.SaveAs("FromFileToPDF.pdf");

        // 3. Transform a URL to PDF
        var targetUrl = "http://ironpdf.com"; // Change to the desired URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(targetUrl);
        pdfDocumentFromUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```

In this C# example, the usage of `IronPdf.ChromePdfRenderer` is showcased to convert different types of HTML sources into PDF format. This includes using simple HTML strings, HTML files, and URLs. Each process is straightforward, making the creation of PDF documents efficient and easily customizable.