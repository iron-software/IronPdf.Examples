***Based on <https://ironpdf.com/examples/generate-pdf-in-csharp/>***

IronPDF empowers developers to effortlessly create PDF documents in C#, F#, and VB.NET for both .NET Core and .NET Framework.

In this tutorial, we illustrate how a PDF document can be crafted from HTML.

Developers are free to utilize straightforward HTML as demonstrated, or enhance their documents with CSS, images, and JavaScript.

IronPDF offers a "[pixel perfect conversion of HTML to PDF](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/)", comparable to the desktop version of Google Chrome.

Below is an example that shows how to generate a PDF from HTML using C#:

```csharp
// Include the IronPdf library, essential for handling PDF creation
using IronPdf;
using System;

public class PdfGenerator
{
    public static void Main(string[] args)
    {
        // Set up a basic HTML string. You can expand this HTML with CSS and JavaScript as well
        string htmlContent = "<h1>Welcome to IronPDF!</h1><p>Learn to convert HTML to PDF simply.</p>";

        // Instantiate a new HtmlToPdf object, which facilitates the HTML to PDF conversion process
        var htmlConverter = new HtmlToPdf();

        // Execute the conversion of the HTML string to a PDF
        // The RenderHtmlAsPdf method accepts the HTML string as its argument
        PdfDocument document = htmlConverter.RenderHtmlAsPdf(htmlContent);

        // Specify the output file path for the resulting PDF
        string outputFile = "result.pdf";

        // Write the PDF to the chosen location
        document.SaveAs(outputFile);

        // Output a confirmation message about PDF creation
        Console.WriteLine($"PDF has been successfully created and stored at: {outputFile}");
    }
}
```

### Explanation:
- **IronPdf Namespace**: The `IronPdf` namespace is included to leverage the PDF creation capabilities.
- **HtmlToPdf Class**: This class has functionalities to transform HTML into a PDF file.
- **RenderHtmlAsPdf Method**: This function converts HTML content into a PDF.
- **PdfDocument Class**: This represents the PDF file generated, which can be saved to disk.
- **SaveAs Method**: This function writes the generated PDF to a designated path.

This guide shows how to transform a simple HTML snippet into a PDF using IronPDF in C#. You can further modify the HTML to incorporate additional elements such as CSS, images, and JavaScript to create richer PDF documents.