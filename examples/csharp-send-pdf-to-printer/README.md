***Based on <https://ironpdf.com/examples/csharp-send-pdf-to-printer/>***

IronPDF offers a straightforward method for developers to craft PDF files in C#, F#, and VB.NET across .NET Core and .NET Framework platforms.

This example exhibits how a PDF document can be crafted directly from HTML.

Developers may utilize plain HTML or augment it with CSS, images, and JavaScript for more complex documents.

IronPDF delivers rendering that is as sharp as Google Chrome's desktop version, ensuring "[pixel perfect HTML to PDF conversion](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/)".

Below is a practical demonstration of implementing IronPDF in C# to generate a PDF from HTML content:

```csharp
// Import the IronPdf namespace
using IronPdf;

class Program
{
    static void Main()
    {
        // Create an instance of the HtmlToPdf converter
        var htmlToPdfConverter = new HtmlToPdf();

        // HTML markup to be transformed into a PDF document
        string htmlMarkup = "<h1>Welcome!</h1><p>This PDF document was created from HTML by leveraging IronPDF.</p>";

        // Convert HTML to a PDF document
        PdfDocument document = htmlToPdfConverter.RenderHtmlAsPdf(htmlMarkup);

        // Store the PDF file locally
        document.SaveAs("output.pdf");
    }
}
```

### Breakdown:

1. **Library Importation**: We begin by importing the IronPdf library which provides the necessary functionality to transform HTML into PDF format.

2. **Converter Initialization**: An `HtmlToPdf` instance is initialized to manage the HTML-to-PDF conversion process.

3. **HTML Content Setup**: An HTML string is prepared, which will be transformed into the content of the PDF.

4. **HTML to PDF Conversion**: The `RenderHtmlAsPdf` function is invoked to transform the prior HTML string into a `PdfDocument` object.

5. **PDF File Saving**: The `SaveAs` function is used to specify the local filename, "output.pdf", where the PDF will be stored.

With this approach, you can convert any HTML document into a PDF file using IronPDF in a C# application effortlessly.