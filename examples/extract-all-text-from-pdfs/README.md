***Based on <https://ironpdf.com/examples/extract-all-text-from-pdfs/>***

IronPDF excels in [transforming HTML into PDFs](https://ironpdf.com/tutorials/html-to-pdf/) while meticulously preserving the original layout and styling. This functionality is perfect for generating PDF documents like reports, invoices, and manuals directly from web content. The library supports converting HTML files, URLs, and HTML strings into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform HTML string into PDF
        var htmlSnippet = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string to a PDF document.</p>";
        var pdfFromHtmlContent = pdfRenderer.RenderHtmlAsPdf(htmlSnippet);
        pdfFromHtmlContent.SaveAs("FromHtmlStringToPDF.pdf");

        // 2. Transform an HTML file into PDF
        var htmlFile = "path_to_your_html_file.html"; // Path to your HTML file
        var pdfFromFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFile);
        pdfFromFile.SaveAs("FromHtmlFileToPDF.pdf");

        // 3. Transform web URL into PDF
        var websiteUrl = "https://ironpdf.com"; // Webpage URL
        var pdfFromWebUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfFromWebUrl.SaveAs("FromUrlToPDF.pdf");
    }
}
```
In the provided C# code snippet, `IronPdf.ChromePdfRenderer` is utilized to perform three types of PDF conversions: converting an HTML string, an HTML file, and a URL into PDF documents. This demonstration shows how easily IronPDF integrates into .NET applications, allowing developers to enhance functionality with efficient PDF processing capabilities.