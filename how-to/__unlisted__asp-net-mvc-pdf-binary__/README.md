# ASP.NET MVC Generate PDF from View (Code Example Tutorial)

***Based on <https://ironpdf.com/how-to/__unlisted__asp-net-mvc-pdf-binary__/>***


In this tutorial, we demonstrate the feasibility of serving an existing HTML string, PDF documents, or HTML files using ASP.NET MVC. We lay out the steps clearly to help you convert an MVC view into a PDF in your C# project.

<hr class="separator">
<p class="main-content__segment-title">Step 1</p>

## 1. Install IronPDF

To handle and serve existing PDF and HTML files or strings within the ASP.NET MVC framework, you can integrate IronPDF, a versatile C# PDF Library. Start developing with it today. Download the library from the [IronPDF DLL ZIP file](https://ironpdf.com/packages/IronPdf.zip) or install it through the [IronPDF NuGet package](https://www.nuget.org/packages/IronPdf).

<br>

```shell
# Command to install IronPDF via NuGet Package Manager

***Based on <https://ironpdf.com/how-to/__unlisted__asp-net-mvc-pdf-binary__/>***

Install-Package IronPdf
```

<hr class="separator">
<p class="main-content__segment-title">How to Tutorial</p>

## 2. Serve PDF in ASP.NET MVC

Within ASP.NET MVC, serving a PDF can be achieved using the `FileResult` method. IronPDF leverages the [ASP.NET MVC framework](https://dotnet.microsoft.com/apps/aspnet/mvc) to facilitate the return of a PDF document.

Below is an illustrative example of how to provide a PDF from your controller.

```csharp
/**
 * Demonstrating PDF Serving in ASPNET MVC
 * anchor-serve-pdf-in-asp-net-mvc
 */
public FileResult RenderPDFfromHTML(long id) 
{
    // Generate a PDF Document from HTML content
    using var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf and MVC</h1>");

    // Measure the PDF content length
    var contentLength = PDF.BinaryData.Length;

    // Set headers for content length and disposition
    Response.AppendHeader("Content-Length", contentLength.ToString());
    Response.AppendHeader("Content-Disposition", "inline; filename=GeneratedDocument_" + id + ".pdf");

    // Deliver the PDF content
    return File(PDF.BinaryData, "application/pdf");
}
```

This method utilizes HTML content to create a PDF on the fly as highlighted above.

<hr class="separator">

## 3. Serve Existing PDF File

Serving existing PDF files is feasible not only in MVC but also in other [ASP.NET contexts](https://ironpdf.com/get-started/vb-net-pdf/).

```csharp
/**
 * Serving an Existing PDF
 * anchor-serve-existing-pdf-file
 */
Response.Clear();
Response.ContentType = "application/pdf";
Response.AddHeader("Content-Disposition", "attachment; filename=\"GeneratedFileName.pdf\"");

// Transmit the existing PDF file
Response.BinaryWrite(System.IO.File.ReadAllBytes("ExistingPdf.pdf"));

// Clear the buffer and complete the response
Response.Flush();
Response.End();
```

<hr class="separator">

## 4. Serve Existing HTML File or String

```csharp
/**
 * Serving HTML File or String as PDF
 * anchor-serve-existing-html-file-or-string
 */
var Renderer = new IronPdf.ChromePdfRenderer();

// Convert an HMTL file to a PDF
using var PDF = Renderer.RenderHTMLFileAsPdf("Project/MyHtmlDocument.html");

// Alternatively convert directly from an HTML string
// using var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome back to IronPdf</h1>");

Response.Clear();
Response.ContentType = "application/pdf";
Response.AddHeader("Content-Disposition", "attachment; filename=\"GeneratedHTML.pdf\"");

// Output the PDF's binary data to the response
Response.BinaryWrite(PDF.BinaryData);

// Complete and end the response
Response.Flush();
Response.End();
```

This section covers the conversion of both HTML files and strings to PDF, showcasing flexibility in handling different types of content.