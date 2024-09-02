# Generating PDF Documents in C#

Developing PDF documents within C# projects is often a priority for improving speed, accuracy, and efficiency.

Utilizing a robust library with straightforward functionalities allows developers to concentrate more on the task at hand and less on the intricate details involved in PDF generation for both .NET Core and .NET Framework environments.

Below, you'll find several ways to integrate PDF generation into your C# projects, including converting HTML to PDF and generating PDFs from ASPX inputs.

---

#### Step 1

## 1. Incorporate the Free C# Library

For a hands-on approach to this tutorial, first install the IronPDF C# HTML to PDF library. It is freely available for development purposes, enabling the creation of PDFs directly from C# without requiring additional NuGet packages. With comprehensive support for HTML, CSS, JS, and image formats, this library offers a holistic solution to PDF generation.

Obtain the library via [direct file download](https://ironpdf.com/packages/IronPdf.Package.For.Generate.PDF.Documents.zip) or by installing the current version from the [NuGet Package Manager](https://www.nuget.org/packages/IronPdf) to integrate with Visual Studio and your projects.

```shell
Install-Package IronPdf
```

---

#### How to Tutorial

## 2. Compatibility with .NET Framework & .NET Core

IronPDF streamlines the creation and manipulation of PDF files by providing intuitive .NET-compatible methods, enhancing both productivity and development speed across .NET Core and .NET Framework, suitable for projects using .NET Framework version 4 or higher and .NET Core version 2 or higher.

## 3. Intuitive Naming Conventions for Easy PDF Creation

The advantages of the IronPDF library include:
- **Speed**: IronPDF optimizes the PDF creation process, allowing developers to achieve results faster and improve productivity.
- **Simplicity**: The library's methods are well-named and self-explanatory, making it straightforward for developers, from novices to veterans, to generate PDFs efficiently in either VB.NET or C#.

## 4. Generate PDF from HTML String

Creating a PDF from an HTML string is straightforward with IronPDF:

```cs
// Generate a PDF from an HTML string using IronPDF
private void ConvertHtmlToPdf()
{
    var pdfRenderer = new IronPdf.ChromePdfRenderer();
    using var document = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF</h1>");
    var outputPath = "ResultingPdfDocument.pdf";
    document.SaveAs(outputPath); 
}
```

This code snippet efficiently transforms HTML code into a PDF document, utilizing clearly named methods such as `ChromePdfRenderer`, `RenderHtmlAsPdf`, and `SaveAs`.

## 5. Generate PDF from ASPX

Easily generate a PDF from ASPX pages without additional libraries using IronPDF:

```cs
// Convert ASPX to PDF directly
protected void Page_Load(object sender, EventArgs e)
{
    IronPdf.AspxToPdf.RenderThisPageAsPdf();
}
```

## 6. Advanced JavaScript Support

IronPDF is robust, supporting advanced features like JavaScript and responsive design essential for modern web applications, thus eliminating the need for multiple PDF conversion tools.

## 7. Generate PDF with Customized Viewport

Here’s how to set a custom viewport size during PDF generation:

```cs
// Custom viewport settings for HTML to PDF conversion
using IronPdf;
var pdfRenderer = new IronPdf.ChromePdfRenderer();
pdfRenderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
pdfRenderer.ViewPortWidth = 1280;
pdfRenderer.RenderHTMLFileAsPdf("Assets/Responsive.html");
```

Support for JavaScript is enhanced by setting a delay to allow for script processing:

```cs
pdfRenderer.RenderingOptions.EnableJavaScript = true;
pdfRenderer.RenderingOptions.RenderDelay = 500; // milliseconds
```

![C# PDF Generation](https://ironpdf.com/img/pdf/csharp-generate-pdf_2.png "CSharp Generate PDF")