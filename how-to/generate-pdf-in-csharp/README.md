# Generate PDFs in C#

***Based on <https://ironpdf.com/how-to/generate-pdf-in-csharp/>***


Generating and managing PDF documents efficiently in C# projects is a common requirement. A library that offers straightforward functions allows developers to focus more on their primary tasks rather than the intricate details of PDF generation, whether you're working in .NET Core or .NET Framework.

Here, we'll explore various ways to create PDFs in C# projects, for instance, creating PDFs from HTML strings or from ASPX inputs.

---

### Step 1

## 1. Install the Free C# Library

For an optimal learning experience in this tutorial, download the IronPDF C# HTML to PDF library. It's free for development and it enables you to handle the upcoming steps on your own. With this library, creating a PDF using C# becomes straightforward without the need for additional NuGet packages. It supports generating PDFs from HTML, including elements like images, forms, data, pages, CSS, and headers.

You can get the library through [direct file download of IronPDF for PDF Generation](https://ironpdf.com/packages/IronPdf.Package.For.Generate.PDF.Documents.zip) or via the [latest IronPDF NuGet Package](https://www.nuget.org/packages/IronPdf) to integrate into Visual Studio and your projects.

```shell
# Command to install the IronPdf package via NuGet

***Based on <https://ironpdf.com/how-to/generate-pdf-in-csharp/>***

Install-Package IronPdf
```

---

### How to Tutorial

## 2. Utilize .NET Framework & .NET Core

IronPDF streamlines the PDF creation process with its intuitive .NET methods, boosting developer efficiency and speeding up project timelines for both .NET Core and .NET Framework. It is compatible with .NET Framework versions starting from 4 and .NET Core from version 2 upwards. Employ it for dynamic PDF content creation in C# .NET.

---

## 3. Understand the Easy Naming Conventions to Create PDFs

One defining feature of the IronPDF library in .NET PDF generation is its speed and the ease of method naming conventions. Using its HTML to PDF capabilities, you can predictably generate PDFs in C# within web applications and various other .NET project types due to its direct method naming and comprehensive functionality.

---

## 4. Generate a PDF from an HTML String

Generating a PDF in .NET is simple with IronPDF. Here's how you can create a PDF from an HTML string in just a few steps:

```cs
/**
Convert HTML to PDF
anchor-generate-pdf-from-html-string
**/
private void ConvertHtmlToPdf()
{
    // Initialize a new instance of the ChromePdfRenderer
    var Renderer = new IronPdf.ChromePdfRenderer();
    // Convert an HTML string to a PDF file
    using var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF</h1>");
    // Define the file path where the PDF will be saved
    var OutputPath = "WelcomeDocument.pdf";
    // Save the generated PDF to the specified path
    PDF.SaveAs(OutputPath);
}
```

This example demonstrates how straightforward it is to utilize IronPDF's capabilities to convert HTML to PDF.

---

## 5. Create PDFs from ASPX Files

IronPDF simplifies the process of converting ASPX pages to PDF documents:

```cs
/**
Convert ASPX to PDF
anchor-generate-pdf-from-aspx
**/
protected void ConvertAspxToPdf(object sender, EventArgs e)
{
    IronPdf.AspxToPdf.RenderThisPageAsPdf();
}
```

---

## 6. JavaScript Compatibility

IronPDF's advanced features include JavaScript support and responsive design capabilities, thus it comprehends both CSS and JavaScript adeptly without needing auxiliary .NET PDF libraries.

---

## 7. Customizing PDF Viewport

Adjusting the viewport for PDF rendering is vital to tailoring how content is rendered from HTML to PDF:

```cs
/**
Customize PDF Viewport
anchor-generate-pdf-with-custom-viewport
**/
using IronPdf;
IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();

// Choose the CSS media type for rendering
Renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;

// Define the width of the responsive virtual browser window
Renderer.ViewPortWidth = 1280; 

// Convert an HTML file to PDF
Renderer.RenderHtmlAsPdf("https://ironpdf.com/img/pdf/Responsive.html").SaveAs("Responsive-design.pdf");
```

Also, ensure JavaScript execution in PDF rendering by setting a delay:

```cs
Renderer.RenderingOptions.EnableJavaScript = true;
Renderer.RenderingOptions.RenderDelay = 500; // milliseconds
```

![](https://ironpdf.com/img/pdf/csharp-generate-pdf_2.png "CSharp Generate PDF")