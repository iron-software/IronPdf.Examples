# C# PDF Viewers

***Based on <https://ironpdf.com/how-to/net-pdf-viewer/>***


This text delves into the different ways to display PDF files in .NET applications, emphasizing the ease with which one can integrate PDF viewing functionalities using the IronPDF library.

IronPDF offers a PDF viewing solution specifically designed for MAUI projects. For further details, please refer to "[Viewing PDFs in MAUI for C# .NET](https://ironpdf.com/tutorials/pdf-viewing/)."

### Introduction to IronPDF

---

## ASP.NET & MVC PDF Capabilities

Within web applications, presenting PDFs can be achieved through the use of a browser window or iframe. A viable alternative is employing the robust [pdf.js library from Mozilla](https://mozilla.github.io/pdf.js/), a fully JavaScript-based PDF viewer that offers a comprehensive set of features.

---

## WPF C# PDF Integration

For WPF applications, you can directly embed PDF documents using the native **WebBrowser** control.

---

## Windows Forms PDF Display

Similarly, in Windows Forms (WinForms) applications, the **WebBrowser** control serves well for directly displaying PDF files.

---

## Launching PDFs in the System's Default Viewer

To launch a PDF in an external viewer using any application, you can employ a method using **System.Diagnostics.Process.Start**.

This typically opens the PDF in the system's default web browser or in Adobe Acrobat if it's available.

```cs
using IronPdf;

// Convert HTML to PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");

var outputPath = "ChromePdfRendererOutput.pdf";

// Save the PDF file
pdf.SaveAs(outputPath);

// Use this technique to open the PDF with the default viewer
System.Diagnostics.Process.Start(outputPath);
```

IronPDF also provides capabilities for PDF viewing within MAUI projects. For more details, visit: "[Viewing PDFs in MAUI for C# .NET](https://ironpdf.com/tutorials/pdf-viewing/)."