# IronPDF: Generate PDFs in .NET

***Based on <https://ironpdf.com/examples/generate-pdf-csharp/>***


IronPDF enables .NET developers using C#, F#, and VB.NET in both .NET Core and .NET Framework environments to seamlessly create PDF documents.

This guide illustrates the process of converting HTML into a PDF document.

Developers have the flexibility to use basic HTML as demonstrated here. Additionally, incorporating CSS, images, and JavaScript is also supported.

IronPDF ensures "[pixel perfect with HTML-to-PDF conversion](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/)," matching the quality seen in desktop browsers like Google Chrome.

```csharp
// Include the IronPDF namespace
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate a new HTML to PDF converter
        var pdfConverter = new HtmlToPdf();

        // HTML content to be converted into a PDF
        string htmlContent = @"
            <html>
                <head>
                    <title>Example PDF</title>
                </head>
                <body>
                    <h1>Welcome to PDF Conversion!</h1>
                    <p>This document is created from HTML code.</p>
                </body>
            </html>";

        // Execute the conversion from HTML to PDF
        PdfDocument document = pdfConverter.RenderHtmlAsPdf(htmlContent);

        // Store the PDF on disk
        document.SaveAs("OutputDocument.pdf");

        // Log to console that the PDF has been generated
        Console.WriteLine("Your PDF file has been generated successfully!");
    }
}
```

### Detailed Code Explanation

- **Include IronPDF**: The statement `using IronPdf;` imports the necessary IronPDF namespace for accessing its features.
- **Initialize a Converter**: `new HtmlToPdf();` creates an instance of the HTML to PDF converter which is essential for the transformation process.
- **Specify HTML Content**: The `string htmlContent` variable contains the HTML that is to be transformed into a PDF. This string can include various HTML elements, CSS, and scripts.
- **Convert HTML to PDF**: The function `pdfConverter.RenderHtmlAsPdf(htmlContent);` processes the HTML string and produces a PDF file.
- **Output PDF to File**: The function `document.SaveAs("OutputDocument.pdf");` saves the generated PDF to the desired location.
- **Notification on Console**: The `Console.WriteLine` method displays a message in the console, confirming the successful creation of the PDF document.