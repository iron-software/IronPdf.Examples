# Generating PDF Documents in C#

***Based on <https://ironpdf.com/how-to/generate-pdf-in-csharp/>***


Creating and managing PDF files efficiently in C# projects is always a priority for developers seeking to improve accuracy and efficiency.

By leveraging a robust library with straightforward functions, developers can concentrate on their core tasks, rather than the intricate details involved in PDF generation, applicable across both .NET Core and .NET Framework environments.

Below, you’ll find several practical examples on how to implement PDF generation in your C# projects, including methods for generating PDFs from HTML strings, ASPX inputs, and more.

---

### **Step 1**

## Install the IronPDF Library

For an optimal learning experience with this tutorial, first, install the IronPDF C# HTML to PDF library. This tool is available for free for development purposes, allowing you to practice the examples provided here. It supports creating PDFs directly from HTML, including elements like images, forms, data, and CSS, making it a comprehensive solution for PDF creation in C#.

Get the library here: [direct file download of IronPDF for PDF Generation](https://ironpdf.com/packages/IronPdf.Package.For.Generate.PDF.Documents.zip) or via the [IronPDF NuGet Package](https://www.nuget.org/packages/IronPdf) which can be easily integrated into Visual Studio.

```shell
Install-Package IronPdf
```

---

### **Step 2**

## Work within .NET Framework & .NET Core

IronPDF provides a suite of straightforward and clear .NET methods that facilitate PDF creation, enhancing productivity within .NET Core and .NET Framework environments. The library is compatible with any .NET Framework starting from Version 4, and .NET Core from Version 2.

---

### **Step 3**

## Simplified Method Naming in IronPDF

What highlights IronPDF in the realm of .NET PDF generation?

Primarily, it's the speed and simplicity. IronPDF enables rapid creation of PDFs and improves developer productivity with its clear naming conventions. This makes it particularly accessible for generating PDFs in web applications and various .NET projects using C#, thanks to its HTML to PDF capabilities.

Moreover, ease of use is another significant benefit. IronPDF’s method names are self-explanatory, making it a breeze for developers, whether beginners or veterans, to use this library in their .NET and VB.NET projects.

---

### **Step 4**

## Generating PDF from HTML Strings

Creating a PDF with IronPDF is a straightforward process. For example, to generate a PDF from an HTML string:

```cs
// Convert HTML String to PDF
private void ConvertHtmlToPdf()
{
    var renderer = new IronPdf.ChromePdfRenderer();
    using var pdf = renderer.RenderHtmlAsPdf("<h1>Explore IronPDF</h1>");

    var outputPath = "ResultingPdfFromHtml.pdf";
    pdf.SaveAs(outputPath);
}
```
This snippet demonstrates how only a few lines of code are needed to create a PDF from an HTML string, showcasing methods like `RenderHtmlAsPdf` and `SaveAs`.
  
---

### **Step 5**

## Generating PDF from ASPX

Here's another example demonstrating the simplicity of using IronPDF, this time to generate a PDF from an ASPX file:

```cs
// Convert ASPX Page to PDF
protected void Page_Load(object sender, EventArgs e)
{
    IronPdf.AspxToPdf.RenderThisPageAsPdf();
}
```

---

### **Step 6**

## Enhanced JavaScript Support

IronPDF stands out with its comprehensive support for JavaScript and CSS, making it a top choice for developers who need a versatile PDF manipulation tool. IronPDF can interpret both CSS and JavaScript effectively, eliminating the need for additional .NET PDF tools.

---

### **Step 7**

## Customizing the PDF Viewport

IronPDF allows you to precisely manage the viewport settings when generating PDFs, enhancing responsiveness in your documents.

Example of setting a custom viewport:

```cs
using IronPdf;
var renderer = new IronPdf.ChromePdfRenderer();

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.ViewPortWidth = 1280;
renderer.RenderHTMLFileAsPdf("Assets/responsive.html");
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.RenderDelay = 500; // milliseconds to allow JS execution
```
Implementing responsiveness and JavaScript handling is streamlined with these settings.

![](https://ironpdf.com/img/pdf/csharp-generate-pdf_2.png "CSharp Generate PDF")