# C# PDF Viewers

***Based on <https://ironpdf.com/how-to/net-pdf-viewer/>***


This guide discusses various strategies for displaying PDFs in .NET applications. The integration of PDF viewing is a widespread requirement that can be tackled using the .NET PDF Library.

IronPDF offers a PDF viewer compatible with MAUI projects. For additional details, refer to: "[Viewing PDFs in MAUI for C# .NET](https://ironpdf.com/tutorials/pdf-viewing/)."

## Quickstart: Viewing PDFs with IronPDF in C#

Start viewing PDFs in your .NET applications promptly with IronPDF. This brief tutorial guides you through embedding a PDF viewer using IronPDF's straightforward API. It allows the seamless loading and presenting of PDF documents, ideal for developers aiming to quickly add PDF viewing features to their C# applications.

```cs
:title=Instantly embed a PDF viewer using IronPDF!
new IronPdf.Viewer.Maui.IronPdfView { Source = IronPdf.Viewer.Maui.PdfViewSource.FromFile("yourfile.pdf") };
```

## ASP.NET & MVC PDF viewer

In web applications, you can render PDFs in a browser window or an iframe. Alternatively, consider employing the robust [pdf.js library from Mozilla](https://mozilla.github.io/pdf.js/), which delivers an extensive PDF viewer completely developed in JavaScript.

<hr class="separator">

## WPF C# PDF Viewer

To display PDF documents in WPF applications, the built-in `WebBrowser` control can be utilized.

<hr class="separator">

## Windows Forms PDF Viewer

Similarly, for Windows Forms (WinForms) applications, employing the `WebBrowser` control is equally effective.

<hr class="separator">

## Viewing a PDF in the Default System PDF Viewer

To display a PDF externally from any application, you can utilize a technique that involves `System.Diagnostics.Process.Start`. This function launches the PDF in the system's default viewer, such as a web browser or Adobe Acrobat, when available.

```csharp
using IronPdf;

// Convert any HTML snippet or full document to PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>IronPDF Greetings</h1>");

var filePath = "GeneratedPdfDocument.pdf";

// Save the PDF file
pdf.SaveAs(filePath);

// Open the PDF using this simple method to view it with the system's default PDF viewer
System.Diagnostics.Process.Start(filePath);
```

This code snippet showcases how to employ `System.Diagnostics.Process.Start` for launching a PDF with the system's default PDF viewer. Make sure the specified path in your file directs to a legitimate PDF document on your machine.

IronPDF also supports viewing PDFs in MAUI projects. Find out more by visiting: "[Viewing PDFs in MAUI for C# .NET](https://ironpdf.com/tutorials/pdf-viewing/)."