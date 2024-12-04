# IronPDF: The Premier C# PDF Library

***Based on <https://ironpdf.com/how-to/fsharp-pdf-library-html-to-pdf/>***


IronPDF, a leading .NET library developed by Iron Software, provides developers with powerful tools for generating and manipulating PDF files directly from within their .NET applications. Whether you are working on a .NET Framework, .NET Core, or .NET Standard project, IronPDF seamlessly integrates into your developer toolkit, allowing you to convert HTML to PDF, create, sign, and edit PDF documents with ease.

## Getting Started with IronPDF

To begin utilizing IronPDF, start by adding the library to your project via the NuGet Package Manager:

```bash
PM> Install-Package IronPdf
```

After installation, you can immediately begin transforming HTML pages into pristine PDF documents by integrating the following namespaces in your C# script:

```csharp
using IronPdf;
using IronPdf.Rendering;
```

Here’s a basic example to create a PDF from HTML content:

```csharp
// Initializing the Pdf Renderer
var renderer = new ChromePdfRenderer();

// Generating PDF from HTML
var pdfDocument = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF</h1>");

// Saving the PDF to a file
pdfDocument.SaveAs("example.pdf");
```

This straightforward approach allows you to generate high-quality PDFs in any .NET application quickly.

## Advanced Usage

For more complex tasks, IronPDF supports a wealth of features, including CSS styling, JavaScript, and high-resolution images in your PDFs. Below is an example of advanced HTML rendering:

```csharp
// Initialize the renderer and set assets path
var advancedRenderer = new ChromePdfRenderer();
advancedRenderer.RenderingOptions.AssetPath = @"C:\site\assets\";

// Sample HTML content with CSS and Images
string htmlContent = @"
    <h1 style='color: blue;'>Styled Header</h1>
    <img src='icons/iron.png'>
";

// Convert HTML to a PDF document with assets
var advancedPdf = advancedRenderer.RenderHtmlAsPdf(htmlContent);

// Save the generated PDF
advancedPdf.SaveAs("styled-example.pdf");
```

This snippet demonstrates the incorporation of external CSS files and images, ensuring that the layout and style match your specifications precisely.

Visit the official IronPDF documentation at [IronPDF Documentation](https://ironpdf.com/docs/) for more detailed instructions and feature descriptions.

With IronPDF, .NET developers have access to an extensive suite of functionalities that simplify PDF generation and manipulation, making it an invaluable component of a developer’s toolkit. Whether for generating reports, automating document handling, or integrating complex PDF functionalities into .NET applications, IronPDF stands out as a top choice.