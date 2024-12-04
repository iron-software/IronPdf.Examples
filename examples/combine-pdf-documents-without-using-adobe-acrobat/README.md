***Based on <https://ironpdf.com/examples/combine-pdf-documents-without-using-adobe-acrobat/>***

IronPDF's standout feature is [HTML to PDF Conversion Tutorial](https://ironpdf.com/tutorials/html-to-pdf/) which effectively maintains the original layouts and styles. This capability allows for the creation of PDF documents from web-based content, including reports, invoices, and various forms of documentation. IronPDF supports the conversion of HTML files, URLs, and HTML strings directly into PDF documents.

Here is how to utilize IronPDF for different HTML to PDF conversion scenarios:

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfGenerator = new ChromePdfRenderer();

        // Example 1: Creating PDF from HTML string
        var htmlCode = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from an HTML string seamlessly.</p>";
        var pdfFromHtml = pdfGenerator.RenderHtmlAsPdf(htmlCode);
        pdfFromHtml.SaveAs("FromHtmlStringToPDF.pdf");

        // Example 2: Creating PDF from HTML file
        var filePath = "your_html_file.html"; // Update this with the actual HTML file path
        var pdfFromFile = pdfGenerator.RenderHtmlFileAsPdf(filePath);
        pdfFromFile.SaveAs("FromFileToPDF.pdf");

        // Example 3: Creating PDF from a Web URL
        var websiteUrl = "https://ironpdf.com"; // Update this with the desired URL
        var pdfFromWebsite = pdfGenerator.RenderUrlAsPdf(websiteUrl);
        pdfFromWebsite.SaveAs("FromUrlToPDF.pdf");
    }
}
```
This code snippet demonstrates three primary methods for generating PDFs: from plain HTML content, from an HTML file, and from a web URL, showcasing the versatility of IronPDF in handling different sources for PDF generation.