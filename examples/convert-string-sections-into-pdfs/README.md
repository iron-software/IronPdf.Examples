The primary functionality of IronPDF is the [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/) conversion, which accurately maintains the original layouts and styles. This feature is ideal for creating PDF documents from web content, encompassing reports, invoices, and other types of documentation. It offers flexibility to convert from HTML files, URLs, and HTML strings directly into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var renderer = new ChromePdfRenderer();

        // 1. Convert HTML String into a PDF
        var htmlSnippet = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from an HTML string right here.</p>";
        var pdfDocumentFromHtmlString = renderer.RenderHtmlAsPdf(htmlSnippet);
        pdfDocumentFromHtmlString.SaveAs("FromHTMLStringToPDF.pdf");

        // 2. Transform HTML File into PDF
        var htmlFileLocation = "your_html_file_path.html"; // Define the path to your HTML file
        var pdfDocumentFromHtmlFile = renderer.RenderHtmlFileAsPdf(htmlFileLocation);
        pdfDocumentFromHtmlFile.SaveAs("FromHTMLFileToPDF.pdf");

        // 3. Convert a Web URL into PDF
        var websiteUrl = "http://ironpdf.com"; // Define the URL to convert
        var pdfDocumentFromUrl = renderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("FromURLToPDF.pdf");
    }
}
```