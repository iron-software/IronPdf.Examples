# ASP.NET MVC: Creating PDFs from Views (Detailed Guide)

***Based on <https://ironpdf.com/how-to/asp-net-mvc-pdf-binary/>***


This guide explains how to generate PDFs using ASP.NET MVC by converting HTML views and files, accessing existing PDF documents, or rendering strings to PDF. Follow the step-by-step instructions below to integrate PDF features into your C# project using IronPDF.


<hr class="separator">
<p class="main-content__segment-title">Step 1</p>

## 1. Setting Up IronPDF

For handling PDFs, HTML files, and strings in ASP.NET MVC, IronPDF is an excellent choice. Utilize the C# PDF Library by IronPDF, which is free for development. Begin by downloading it either from [IronPDF DLL ZIP file](https://ironpdf.com/packages/IronPdf.Package.For.MVC.View.PDF.zip) or via the [IronPDF NuGet package](https://www.nuget.org/packages/IronPdf).

<br>

```shell
/Install-Package IronPdf
```

<hr class="separator">
<p class="main-content__segment-title">Tutorial Steps</p>

## 2. Deliver PDFs in ASP.NET MVC

Producing a PDF in ASP.NET MVC can be accomplished by implementing a `FileResult` method. Using the IronPDF library along with the [ASP.NET MVC framework](https://dotnet.microsoft.com/apps/aspnet/mvc), you can efficiently return PDF files in your applications as demonstrated below.

```cs
/**
Generate PDF within ASP.NET MVC
anchor-generate-pdf-in-asp-net-mvc
**/
public FileResult RenderPDFfromHTML(long documentId) {

  //Generate a new PDF file

  using var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf and MVC</h1>");

  //Prepare PDF data for response

  var contentLength = PDF.BinaryData.Length;

  Response.AppendHeader("Content-Length", contentLength.ToString());

  Response.AppendHeader("Content-Disposition", "inline; filename=GeneratedDoc_" + documentId + ".pdf");

  return File(PDF.BinaryData, "application/pdf;");

}
```

In more sophisticated scenarios, you could render an HTML view to a string and then transform it into a PDF using the above method.

<hr class="separator">

## 3. Handling Existing PDF Files

PDFs can also be served directly in other ASP.NET contexts too.

```cs
/**
Output Pre-existing PDF
anchor-output-existing-pdf-file
**/
Response.Clear();

Response.ContentType = "application/pdf";

Response.AddHeader("Content-Disposition","attachment;filename=\"SelectedFile.pdf\"");

// Modify to show the file in browser using a specific file name

Response.BinaryWrite(System.IO.File.ReadAllBytes("StoredFile.pdf"));

// Converts our PDF to bytes and sends to the client

Response.Flush();

Response.End();

```

<hr class="separator">

## 4. Managing HTML Files or Strings

```cs
/**
Output HTML as PDF
anchor-output-html-as-pdf
**/
var Renderer = new IronPdf.ChromePdfRenderer();

using var PDF = Renderer.RenderHTMLFileAsPdf("Project/MyHtmlDocument.html");

// Alternatively convert a HTML string:

//var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");

Response.Clear();

Response.ContentType = "application/pdf";

Response.AddHeader("Content-Disposition","attachment;filename=\"OutputFile.pdf\"");

// Modify to display the file in the browser and change the file name if necessary

Response.BinaryWrite( PDF.BinaryData );

Response.Flush();

Response.End();

```