***Based on <https://ironpdf.com/examples/generate-pdfs-from-multiline-strings/>***

IronPDF excels at [converting HTML content into PDF documents](https://ironpdf.com/tutorials/html-to-pdf/), meticulously preserving their layouts and styles. This functionality is particularly useful for creating PDF versions of web content like reports, invoices, and various forms of documentation. IronPDF can handle conversions from HTML files, URLs, and raw HTML strings into professional-quality PDFs.


```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // Example 1: Convert an HTML string to a PDF document
        var htmlStringContent = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string to a PDF.</p>";
        var pdfDocumentFromString = pdfRenderer.RenderHtmlAsPdf(htmlStringContent);
        pdfDocumentFromString.SaveAs("HTMLStringToPDF.pdf");

        // Example 2: Create a PDF from an HTML file
        var htmlFileLocation = "path_to_your_html_file.html"; // Define the HTML file path
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFileLocation);
        pdfDocumentFromFile.SaveAs("HTMLFileToPDF.pdf");

        // Example 3: Create a PDF from a website URL
        var websiteUrl = "https://ironpdf.com"; // Define the website URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("URLToPDF.pdf");
    }
}
```

This example illustrates how IronPDF can be used to convert different HTML sources into ready-to-distribute PDFs, underlining the flexibility and efficiency of the IronPDF library in various use cases.