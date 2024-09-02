IronPDF's standout capability is transforming HTML into PDFs, flawlessly maintaining the original layouts and styling. This function is ideal for creating PDFs from web material, including reports, invoices, and documentation. It seamlessly handles the conversion of HTML files, URLs, and HTML strings into PDF documents. More details about this feature can be explored through [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/).

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // Example 1: HTML String to PDF Conversion
        var htmlSample = "<h1>Welcome to IronPDF!</h1><p>Generating a PDF from an HTML string.</p>";
        var pdfFromString = pdfRenderer.RenderHtmlAsPdf(htmlSample);
        pdfFromString.SaveAs("ConvertedFromString.pdf");

        // Example 2: HTML File to PDF Conversion
        var htmlFilePath = "path_to_your_html_file.html"; // Path to your HTML file
        var pdfFromFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFilePath);
        pdfFromFile.SaveAs("ConvertedFromFile.pdf");

        // Example 3: Web URL to PDF Conversion
        var webUrl = "http://ironpdf.com"; // Web URL to convert
        var pdfFromWeb = pdfRenderer.RenderUrlAsPdf(webUrl);
        pdfFromWeb.SaveAs("ConvertedFromURL.pdf");
    }
}
```

In the examples provided, the `ChromePdfRenderer` is used to create PDF documents from various HTML sources. The process is delineated into three parts: converting an HTML string, an HTML file, and a URL to PDF. Each method demonstrates the simplicity and effectiveness of IronPDF in generating documentation from different HTML inputs.