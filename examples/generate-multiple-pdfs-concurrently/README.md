***Based on <https://ironpdf.com/examples/generate-multiple-pdfs-concurrently/>***

IronPDF's standout capability is the [HTML to PDF Conversion](https://ironpdf.com/tutorials/html-to-pdf/) that effectively retains the original layouts and styles. This tool is useful for generating PDFs from web content, and is ideal for creating reports, invoices, and documentation. It enables the conversion of HTML files, URLs, and HTML strings directly into PDF files.

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var chromePdfRenderer = new ChromePdfRenderer();

        // 1. Convert HTML String to PDF
        var htmlSample = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from an HTML string.</p>";
        var pdfDocumentFromHtmlString = chromePdfRenderer.RenderHtmlAsPdf(htmlSample);
        pdfDocumentFromHtmlString.SaveAs("HTMLStringToPDF.pdf");

        // 2. Convert HTML File to PDF
        var filePathToHtml = "your_html_file_path.html"; // Define the path to your HTML file
        var pdfDocumentFromHtmlFile = chromePdfRenderer.RenderHtmlFileAsPdf(filePathToHtml);
        pdfDocumentFromHtmlFile.SaveAs("HTMLFileToPDF.pdf");

        // 3. Convert URL to PDF
        var websiteUrl = "https://ironpdf.com"; // Provide the URL
        var pdfDocumentFromUrl = chromePdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("URLToPDF.pdf");
    }
}
```

This code example demonstrates how easy it is to convert various HTML sources into PDF files using IronPDF, highlighting the ease with which web content can be archived or shared in a universally accessible format.