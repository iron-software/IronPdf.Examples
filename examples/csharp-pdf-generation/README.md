***Based on <https://ironpdf.com/examples/csharp-pdf-generation/>***

IronPDF empowers developers to effortlessly generate PDF files using C#, F#, and VB.NET across .NET Core and .NET Framework platforms.

In the following guide, we’ll explore how to generate a PDF document from HTML. Your HTML can be as straightforward as our example, or you may enhance it with CSS, images, and JavaScript for richer formatting and functionality.

IronPDF offers [pixel-perfect rendering when converting HTML to PDF](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/), delivering results comparable to desktop versions of Google Chrome.

```csharp
// Include the IronPdf library
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate a new HtmlToPdf object with the default configuration
        var Renderer = new HtmlToPdf();

        // HTML string to be converted into a PDF document
        string htmlContent = @"
        <!DOCTYPE html>
        <html>
        <head>
            <title>Sample PDF</title>
            <style>
                body { font-family: 'Arial', sans-serif; }
                h1 { color: navy; }
            </style>
        </head>
        <body>
            <h1>Welcome to IronPDF!</h1>
            <p>This PDF was crafted from HTML using IronPDF.</p>
        </body>
        </html>";

        // Transform the HTML to a PDF file
        PdfDocument pdf = Renderer.RenderHtmlAsPdf(htmlContent);

        // Store the newly created PDF
        pdf.SaveAs("output.pdf");

        // Show successful creation message to the user
        System.Console.WriteLine("Successfully generated 'output.pdf'. The PDF file has been saved.");
    }
}
```

In this demonstration:

- The `IronPdf` library is included to enable PDF rendering capabilities.
- We construct a `HtmlToPdf` object, which allows us to convert HTML into PDF.
- A sample HTML string is presented, featuring a heading and a paragraph that utilize elementary CSS for styling.
- Utilizing `RenderHtmlAsPdf`, the HTML is converted into a `PdfDocument`.
- After generating the PDF, it is saved under the name `output.pdf`, followed by a message confirming the action.

You are encouraged to build upon this basic setup by incorporating more intricate HTML, adding CSS styles, employing JavaScript, or adapting dynamic data for your PDF content creation needs.