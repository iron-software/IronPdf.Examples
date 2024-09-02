One of the standout features of IronPDF is its ability to convert HTML to PDF while retaining the original layouts and styles. This functionality is ideal for generating PDFs from web content such as reports, invoices, and documentation. It offers the flexibility to transform HTML files, URLs, and HTML strings directly into PDF documents. For more detailed guidance, see [HTML to PDF Conversion](https://ironpdf.com/tutorials/html-to-pdf/).

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Converting an HTML string into a PDF document
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>Convert HTML strings into PDF format easily.</p>";
        var pdfDocumentFromHtml = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocumentFromHtml.SaveAs("ConvertedFromHTMLString.pdf");

        // 2. Transforming an HTML file into a PDF file
        var filePath = "path_to_your_html_file.html"; // Replace with your HTML file's path
        var pdfDocumentFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocumentFromFile.SaveAs("ConvertedFromHTMLFile.pdf");

        // 3. Creating a PDF from a Web URL
        var websiteUrl = "http://ironpdf.com"; // Change to the desired URL
        var pdfDocumentFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocumentFromUrl.SaveAs("ConvertedFromURL.pdf");
    }
}
```

In the provided C# example, `IronPdf.ChromePdfRenderer` is used to demonstrate three core capabilities: converting an HTML string, an HTML file, and content from a URL into PDF files. Each segment of the code is annotated to assist in understanding the file transformation process, ensuring that it's as straightforward as possible to implement with IronPDF.