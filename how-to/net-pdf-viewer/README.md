# C# PDF Viewers

This document will discuss different strategies to display PDFs in a .NET framework application. It's quite common for software applications to need the ability to show PDF files, and this requirement can be seamlessly integrated using the PDF Library for .NET.

IronPDF offers a PDF viewer specifically designed for MAUI projects. For detailed guidance, refer to the page: "[Viewing PDFs in MAUI for C# .NET](https://ironpdf.com/tutorials/pdf-viewing/)."

## ASP.NET & MVC PDF Viewer

In the context of web applications, PDF files can be displayed directly within a browser window or an iframe. Another excellent method is to employ Mozilla's [pdf.js library](https://mozilla.github.io/pdf.js/), a robust PDF viewer that operates entirely in JavaScript.

<hr class="separator">

## WPF C# PDF Viewer

For incorporating PDF viewing capabilities within WPF applications, the inbuilt **WebBrowser** control can be utilized to achieve this.

<hr class="separator">

## Windows Forms PDF Viewer

Similarly, for Windows Forms (WinForms) applications, the **WebBrowser** control serves as an effective method to view PDF documents directly.

<hr class="separator">

## Viewing a PDF in the Default System PDF Viewer

To load a PDF file in the default system PDF viewer through any application, a useful technique involves using **System.Diagnostics.Process.Start**. This typically opens the PDF in the system's default web browser that supports PDF viewing, or might launch Adobe Acrobat if it’s available.

```cs
using IronPdf;

// Convert HTML content to a PDF file
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");

var outputPath = "ChromePdfRenderer.pdf";

// Save the PDF file locally
pdf.SaveAs(outputPath);

// Opening the PDF with the default system viewer
System.Diagnostics.Process.Start(outputPath);
```

IronPDF also furthers its support for MAUI projects with a dedicated PDF viewer. More details can be found on: "[Viewing PDFs in MAUI for C# .NET](https://ironpdf.com/tutorials/pdf-viewing/)."