# ASP.NET MVC Generate PDF from View (Complete Guide)

***Based on <https://ironpdf.com/how-to/asp-net-mvc-pdf-binary/>***


Transforming HTML files, strings, or existing PDF documents into a PDF within an ASP.NET MVC application is detailed in this guide. Follow the steps below to seamlessly incorporate PDF generation into your C# project using MVC views.

<hr class="separator">
<p class="main-content__segment-title">Step 1</p>

## 1. Install IronPDF

To manage existing PDF files, HTML files, or strings, as well as enabling PDF generation in ASP.NET MVC, you can utilize the C# PDF Library provided by IronPDF. It's available for free during development. Begin by downloading it with the steps outlined in this guide. You can access it via [IronPDF DLL ZIP file](https://ironpdf.com/packages/IronPdf.Package.For.MVC.View.PDF.zip) or through the [IronPDF NuGet package](https://www.nuget.org/packages/IronPdf).

```shell
Install-Package IronPdf
```

<hr class="separator">
<p class="main-content__segment-title">How to Tutorial</p>

## 2. Serve PDF in ASP.NET MVC

Serving a PDF in ASP.NET MVC involves utilizing the [FileResult](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.fileresult) method. IronPDF integrates smoothly with the [ASP.NET MVC framework](https://dotnet.microsoft.com/apps/aspnet/mvc) allowing you to deliver PDF files from your controller as demonstrated below.

```cs
/**
Serve PDF in ASPNET MVC
anchor-serve-pdf-in-asp-net-mvc
**/
public FileResult GetHTMLPageAsPDF(long id) {

  // Create and populate a PDF Document
  using var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf and MVC</h1>");

  // Return a PDF document directly from a view
  var contentLength = PDF.BinaryData.Length;

  Response.AppendHeader("Content-Length", contentLength.ToString());
  Response.AppendHeader("Content-Disposition", "inline; filename='GeneratedDocument_" + id + ".pdf'");

  return File(PDF.BinaryData, "application/pdf");

}
```

This can also be adapted to render HTML views directly to PDF, by converting an HTML string into a PDF file as outlined above.

<hr class="separator">

## 3. Serve Existing PDF File 

Serving an existing PDF directly within ASP.NET can also be done as shown below.

```cs
/**
Serve Existing PDF
anchor-serve-existing-pdf-file
**/
Response.Clear();

Response.ContentType = "application/pdf";

Response.AddHeader("Content-Disposition","attachment;filename=\"PreExistingDocument.pdf\"");

// Modify this line to display the PDF in the browser under a specific file name
Response.BinaryWrite(System.IO.File.ReadAllBytes("<Path to PDF>"));

// Transmits the PDF as a byte array then sends it to the output buffer
Response.Flush();

Response.End();

```

<hr class="separator">

## 4. Serve Existing HTML File or String

```cs
/**
Serve Existing HTML File or String
anchor-serve-existing-html-file-or-string
**/
var Renderer = new IronPdf.ChromePdfRenderer();

// Convert an HTML file to a PDF
using var PDF = Renderer.RenderHTMLFileAsPdf("Path/To/MyHtmlDocument.html");

// Alternatively, convert an HTML string directly
// var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");

Response.Clear();

Response.ContentType = "application/pdf";

Response.AddHeader("Content-Disposition","attachment;filename=\"HTMLConversion.pdf\"");

// Modify this line to allow the PDF to be displayed directly in the browser
Response.BinaryWrite(PDF.BinaryData);

Response.Flush();

Response.End();

```

This comprehensive guide outlines the process of serving both static PDF files and dynamically generated PDF documents from HTML content using IronPDF in an ASP.NET MVC environment.