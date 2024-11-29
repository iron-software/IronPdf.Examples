***Based on <https://ironpdf.com/examples/create-a-pdf-after-a-three-second-delay/>***

IronPDF excels in converting HTML into PDF, ensuring that the layouts and designs are maintained. It enables PDF creation from web content, ideal for reports, invoices, and documentation. The library is adept at converting HTML files, URLs, and HTML strings directly into PDF files.

```cs
using IronPdf;

class Example
{
    static void Main()
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transform HTML String into PDF
        var htmlString = "<h1>Welcome to IronPDF!</h1><p>Convert this HTML string into a PDF file.</p>";
        var pdfDocFromHtmlString = pdfRenderer.RenderHtmlAsPdf(htmlString);
        pdfDocFromHtmlString.SaveAs("StringToPDF.pdf");

        // 2. Convert HTML File to PDF File
        var filePath = @"local_path_to_your_html.html";  // Define the path to your HTML file here
        var pdfDocFromFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfDocFromFile.SaveAs("FileToPDF.pdf");

        // 3. Creating PDF from a URL
        var websiteUrl = "https://ironpdf.com"; // Define the URL here
        var pdfDocFromUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfDocFromUrl.SaveAs("WebToPDF.pdf");
    }
}
```

For additional information on IronPDF's capabilities, please visit the [IronPDF Product Page](https://ironpdf.com) or explore more options by visiting [Iron Software's Product Suite](https://ironsoftware.com).