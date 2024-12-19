***Based on <https://ironpdf.com/examples/generate-pdfs-with-default-parameters/>***

IronPDF's flagship capability, [HTML to PDF Conversion](https://ironpdf.com/tutorials/html-to-pdf/), stands out by preserving the original layouts and styles. This feature enables the generation of PDFs from various web sources like reports, invoices, and documentation, seamlessly converting HTML files, URLs, and HTML strings into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string [] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform an HTML string into a PDF
        var htmlSnippet = "<h1>Welcome to IronPDF!</h1><p>Generate your PDF from an HTML string here.</p>";
        var pdfFromHTML = pdfRenderer.RenderHtmlAsPdf(htmlSnippet);
        pdfFromHTML.SaveAs("ConvertedFromHTMLString.pdf");

        // 2. Convert an HTML file into a PDF
        var pathToHtml = "path_to_your_html_file.html"; // Define your HTML file path
        var pdfFromFile = pdfRenderer.RenderHtmlFileAsPdf(pathToHtml);
        pdfFromFile.SaveAs("ConvertedFromHTMLFile.pdf");

        // 3. Turn a Web URL into a PDF
        var websiteUrl = "http://ironpdf.com"; // Define the URL
        var pdfFromWeb = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfFromWeb.SaveAs("ConvertedFromURL.pdf");
    }
}
```
In this example, the `ChromePdfRenderer` is utilized to perform three main conversions: transforming HTML strings, files, and URLs into functional PDF documents, making the process adaptable for various needs and applications.