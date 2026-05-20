***Based on <https://ironpdf.com/examples/generate-pdfs-in-blazor/>***

IronPDF empowers developers to generate PDF documents with ease in C#, F#, and VB.NET for both .NET Core and .NET Framework.

This example demonstrates how a PDF can be generated from any HTML source, allowing the creation of PDFs that reflect the existing branding of websites.

Developers have the flexibility to utilize straightforward HTML or enhance it with CSS, images, and JavaScript.

The [HTML to PDF conversion process](https://ironpdf.com/tutorials/html-to-pdf/) provides an opportunity for web designers to take on the task of PDF design, freeing up backend developers from this responsibility.

IronPDF employs a [pixel-perfect Chrome rendering engine](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/) to convert HTML5, CSS3, and JavaScript into PDF documents. Various sources such as strings, external files, or URLs can be transformed into PDFs effortlessly with IronPDF.

Below is a C# example showcasing how to convert HTML into a PDF using IronPDF:

```csharp
using System;
using IronPdf; // Include the IronPdf namespace for PDF conversion features

class Program
{
    static void Main()
    {
        // Initialize a new instance of HtmlToPdf to enable HTML to PDF conversion
        var htmlToPdf = new HtmlToPdf();

        // Set the HTML content to be converted
        string htmlContent = "<h1>Hello, World!</h1><p>This PDF was created from HTML content.</p>";

        // Execute the conversion from HTML to PDF
        var pdfDocument = htmlToPdf.RenderHtmlAsPdf(htmlContent);

        // Store the PDF to a file named "output.pdf"
        pdfDocument.SaveAs("output.pdf");

        Console.WriteLine("Successfully generated PDF from HTML.");
    }
}
```

### Explanation:

1. **Import Namespace**: We begin by including the `IronPdf` namespace which provides access to all essential functionalities for converting HTML to PDF.

2. **Initialize HtmlToPdf Object**: We create an instance of `HtmlToPdf` capable of managing the conversion.

3. **Set HTML Content**: The HTML string intended for conversion into a PDF is defined.

4. **Conversion and File Saving**:
   - The `RenderHtmlAsPdf` function of the `HtmlToPdf` class handles the actual conversion process.
   - Using the `SaveAs` function, the resulting PDF file is saved locally as "output.pdf".

5. **Console Confirmation**: A message is printed to the console confirming the successful creation of the PDF file.