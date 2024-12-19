***Based on <https://ironpdf.com/examples/generate-pdfs-from-multiline-strings/>***

IronPDF primarily excels at [converting HTML content to PDF documents](https://ironpdf.com/tutorials/html-to-pdf/), maintaining both the format and the styles. This functionality is particularly useful for creating PDF versions of web content such as reports, invoices, and other documentation. It adeptly handles the conversion of HTML files, URLs, and HTML strings into PDF files.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform an HTML string into a PDF document
        var sampleHtml = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from an HTML string.</p>";
        var pdfDocumentFromHtml = pdfRenderer.RenderHtmlAsPdf(sampleHtml);
        pdfDocumentFromHtml.SaveAs("ConvertedHtmlStringToPDF.pdf");

        // 2. Transform an HTML file into a PDF document
        var filePath = "path_to_your_html_file.html"; // Update this with your HTML file path
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocumentFromFile.SaveAs("ConvertedHtmlFileToPDF.pdf");

        // 3. Convert a web URL into a PDF document
        var webUrl = "http://ironpdf.com"; // Enter the URL here
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(webUrl);
        pdfDocumentFromUrl.SaveAs("ConvertedUrlToPDF.pdf");
    }
}
```

In the provided C# code, the `ChromePdfRenderer` object demonstrates the versatility of IronPDF by showcasing three different means of creating PDFs: directly from HTML strings, from HTML files, and from web URLs, ensuring adaptability in various development scenarios.