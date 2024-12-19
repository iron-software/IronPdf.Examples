***Based on <https://ironpdf.com/examples/replace-text-within-html-strings/>***

IronPDF shines with its [HTML to PDF conversion tutorials](https://ironpdf.com/tutorials/html-to-pdf/) that ensure a high fidelity reproduction of layouts and styles. This functionality is essential for creating PDFs sourced from web content, including reports, invoices, and any form of documentation. It adeptly handles the conversion of HTML from files, URLs, and direct HTML strings.

The code example below elaborates on using IronPDF to convert HTML content into PDF:

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // Example 1: Converting an HTML String to a PDF document.
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string to a PDF file.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocumentFromString.SaveAs("ConvertedFromHTMLString.pdf");

        // Example 2: Converting an HTML File to PDF.
        var filePath = "path_to_your_html_file.html"; // Your HTML file's path goes here.
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocumentFromFile.SaveAs("ConvertedFromFile.pdf");

        // Example 3: Converting a Web URL to a PDF document.
        var websiteUrl = "https://ironpdf.com"; // Your target URL.
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("ConvertedFromURL.pdf");
    }
}
```

This extended example showcases three distinct uses of the IronPDF library to transform HTML content into PDFs: direct conversion from an HTML string, conversion from an HTML file, and conversion from a webpage URL, all via the easy-to-use `ChromePdfRenderer`.