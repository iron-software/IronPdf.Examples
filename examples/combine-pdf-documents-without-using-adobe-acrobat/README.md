***Based on <https://ironpdf.com/examples/combine-pdf-documents-without-using-adobe-acrobat/>***

IronPDF's standout feature is its [HTML to PDF Conversion Tutorial](https://ironpdf.com/tutorials/html-to-pdf/), a powerful tool which maintains original layouts and styles meticulously. This functionality is ideal for creating PDFs from various web sources, including content for reports, invoices, and documentation. It effectively handles conversion from HTML files, URLs, and HTML strings.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the PDF renderer
        var pdfRenderer = new ChromePdfRenderer();

        // Example 1: Convert an HTML string to a PDF document
        var htmlContent = "<h1>Welcome to IronPDF!</h1><p>Generate a PDF from this HTML string.</p>";
        var pdfFromHtmlString = pdfRenderer.RenderHtmlAsPdf(htmlContent);
        pdfFromHtmlString.SaveAs("ConvertedHTMLStringToPDF.pdf");

        // Example 2: Convert a local HTML file to a PDF document
        var htmlFilePath = "path_to_your_html_file.html"; // Ensure you specify the correct HTML file path
        var pdfFromHtmlFile = pdfRenderer.RenderHtmlFileAsPdf(htmlFilePath);
        pdfFromHtmlFile.SaveAs("ConvertedHTMLFileToPDF.pdf");

        // Example 3: Convert a web URL to a PDF document
        var webUrl = "http://ironpdf.com"; // Define the URL to convert
        var pdfFromUrl = pdfRenderer.RenderUrlAsPdf(webUrl);
        pdfFromUrl.SaveAs("ConvertedURLToPDF.pdf");
    }
}
```

This snippet demonstrates how to employ IronPDF to convert HTML data into PDF format from three different sources: directly from HTML strings, local HTML files, and web URLs, leveraging clear and concise code for each type.