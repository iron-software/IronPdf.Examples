***Based on <https://ironpdf.com/examples/create-a-pdf-after-a-three-second-delay/>***

IronPDF excels in converting HTML into PDFs, meticulously preserving the layout and styling. It's adept at producing PDFs from various web sources, including reports, invoices, and other documentation. This functionality extends to transforming HTML files, URLs, and HTML strings directly into PDF documents.

```cs
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        var pdfRenderer = new ChromePdfRenderer();

        // 1. Transforming HTML string into a PDF
        var htmlCode = "<h1>Welcome to IronPDF!</h1><p>Generate PDFs from an HTML string easily.</p>";
        var pdfFromHtml = pdfRenderer.RenderHtmlAsPdf(htmlCode);
        pdfFromHtml.SaveAs("HTMLStringToPDFOutput.pdf");

        // 2. Converting an HTML file into a PDF
        var filePath = "your_html_file_path.html"; // Define the HTML file path
        var pdfOutputFromHtmlFile = pdfRenderer.RenderHtmlFileAsPdf(filePath);
        pdfOutputFromHtmlFile.SaveAs("OutputFromHTMLFile.pdf");

        // 3. Creating a PDF from a web URL
        var websiteUrl = "http://ironpdf.com"; // Provide the URL
        var pdfFromWebUrl = pdfRenderer.RenderUrlAsPdf(websiteUrl);
        pdfFromWebUrl.SaveAs("WebUrlToPDF.pdf");
    }
}
```

To delve deeper into the capabilities of IronPDF, check out the [IronPDF Product Page](https://ironpdf.com) or explore additional tools from [Iron Software's Product Suite](https://ironsoftware.com).