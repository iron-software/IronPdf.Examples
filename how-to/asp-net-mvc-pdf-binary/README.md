# ASP.NET MVC Generate PDF from View (Code Example Tutorial)

This tutorial outlines the process of serving various types of documents like HTML files, strings, and PDF documents in ASP.NET MVC. Learn how to easily convert MVC view into PDF in your C# project.

<hr class="separator">
<p class="main-content__segment-title">Step 1</p>

## 1. Install IronPDF

To work with existing PDF files, HTML files, or strings, and to serve PDFs in ASP.NET MVC, we use the C# PDF Library from IronPDF. You can download it for free for development purposes following the instructions below. Obtain the library through the [DLL ZIP file](https://ironpdf.com/packages/IronPdf.Package.For.MVC.View.PDF.zip) or via the [NuGet page](https://www.nuget.org/packages/IronPdf).

<br>

```shell
/Install-Package IronPdf
```

<hr class="separator">
<p class="main-content__segment-title">How to Tutorial</p>

## 2. Serve PDF in ASP.NET MVC

To generate and serve a PDF document in ASP.NET MVC, utilize the [FileResult](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.fileresult) method and IronPDF's [MVC](https://dotnet.microsoft.com/apps/aspnet/mvc) capabilities to return a PDF file.

Employ the method in your controller as illustrated below.

```cs
/**
Serve PDF in ASPNET MVC
anchor-serve-pdf-in-asp-net-mvc
**/
public FileResult GetHTMLPageAsPDF(long id) {

  // Create PDF Document

  using var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf and MVC</h1>");

  // Return a PDF document from a view

  var contentLength = PDF.BinaryData.Length;

  Response.AppendHeader("Content-Length", contentLength.ToString());

  Response.AppendHeader("Content-Disposition", "inline; filename=Document_" + id + ".pdf");

  return File(PDF.BinaryData, "application/pdf;");

}
```

This example can be enhanced by utilizing your HTML view to create an HTML string and subsequently converting it into a PDF.

<hr class="separator">

## 3. Serve Existing PDF File 

Similarly, serving [PDF files in other ASP.NET](https://ironpdf.com/how-to/vb-net-pdf/) environments is straightforward.

```cs
/**
Serve Existing PDF
anchor-serve-existing-pdf-file
**/
Response.Clear();

Response.ContentType = "application/pdf";

Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");

// Modify this line to display in browser and change the file name

Response.BinaryWrite(System.IO.File.ReadAllBytes("MyPdf.pdf"));

// Retrieve our PDF as a byte array, then send it to the output stream

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

using var PDF = Renderer.RenderHTMLFileAsPdf("Project/MyHtmlDocument.html");

// Or convert an HTML string

// var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");

Response.Clear();

Response.ContentType = "application/pdf";

Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");

// Edit this line to display in browser and change the file name

Response.BinaryWrite(PDF.BinaryData);

Response.Flush();

Response.End();

```