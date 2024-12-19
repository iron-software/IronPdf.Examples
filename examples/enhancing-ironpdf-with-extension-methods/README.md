***Based on <https://ironpdf.com/examples/enhancing-ironpdf-with-extension-methods/>***

IronPDF offers a prominent feature that allows [conversion of HTML to PDF while maintaining layout and styles](https://ironpdf.com/tutorials/html-to-pdf/). This functionality is perfect for creating PDFs from web content, including reports, invoices, and documentation, by supporting conversion of HTML files, URLs, and HTML strings directly into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Convert an HTML string into a PDF document
        var htmlSample = "<h1>Welcome to IronPDF!</h1><p>This PDF was generated from an HTML string.</p>";
        var pdfDocumentFromHtmlString = pdfRenderer.RenderHtmlAsPdf(htmlSample);
        pdfDocumentFromHtmlString.SaveAs("FromHTMLStringToPDF.pdf");

        // 2. Convert an HTML file into a PDF document
        var htmlFileLocation = "path_to_your_html_file.html"; // Update this with your actual HTML file path
        var pdfDocumentFromHtmlFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFileLocation);
        pdfDocumentFromHtmlFile.SaveAs("FromHTMLFileToPDF.pdf");

        // 3. Convert a webpage into a PDF document
        var webpageUrl = "http://ironpdf.com"; // Use the intended URL here
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(webpageUrl);
        pdfDocumentFromUrl.SaveAs("FromURLToPDF.pdf");
    }
}
```

In this enhanced version, precisely the same processes are outlined: converting HTML text, files, and web URLs into PDF files using IronPDF's `ChromePdfRenderer`.