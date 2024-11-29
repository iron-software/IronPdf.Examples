***Based on <https://ironpdf.com/examples/generate-multiple-pdfs-concurrently/>***

IronPDF stands out for its [HTML to PDF Conversion](https://ironpdf.com/tutorials/html-to-pdf/) capability, which expertly maintains the original layout and styles. This feature is invaluable for creating PDF documents from web content, including reports, invoices, and various forms of documentation. It effortlessly handles the conversion of HTML files, URLs, and HTML strings into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform HTML String to PDF
        var htmlSource = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string into a PDF document.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlSource);
        pdfDocumentFromString.SaveAs("ConvertedFromString.pdf");

        // 2. Transform HTML File to PDF
        var pathToHtml = "path_to_your_html_file.html"; // Define the HTML file location
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(pathToHtml);
        pdfDocumentFromFile.SaveAs("ConvertedFromFile.pdf");

        // 3. Transform Web URL to PDF
        var websiteUrl = "http://ironpdf.com"; // Point to the URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("ConvertedFromUrl.pdf");
    }
}
```

In this example, we make use of IronPDF's `ChromePdfRenderer` to convert different sources—HTML string, local HTML file, and a website URL—into PDF files. The process is streamlined, and the generated PDF files preserve the content's integrity and formatting.