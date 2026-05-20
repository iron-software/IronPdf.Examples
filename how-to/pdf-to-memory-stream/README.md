# PDF to MemoryStream in C#

***Based on <https://ironpdf.com/how-to/pdf-to-memory-stream/>***


In C# .NET, it's feasible to directly transfer a PDF to a MemoryStream without utilizing the file system. This can be achieved with the `MemoryStream` object, which is part of the `System.IO` namespace in .NET.

## Getting Started: Converting PDF to MemoryStream

Utilize IronPDF's straightforward API to transform your PDF documents into MemoryStream effortlessly. This tutorial is designed to help developers swiftly start with the process of loading a PDF and converting it to a MemoryStream, ideal for fluid integration within .NET applications. Here's an easy example to enhance your skills in managing PDFs in C#.

```cs
:title=Effortlessly Convert PDF to MemoryStream!
using var stream = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Stream Welcome!</h1>").Stream;
```

---

## Storing a PDF in Memory

A `IronPdf.PdfDocument` object provides two methods to save a PDF directly to memory:

- [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) allows exporting the PDF as a `System.IO.MemoryStream`.
- [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) allows exporting the PDF as a byte array (`byte[]`).

```csharp
using IronPdf;
using System.IO;

var renderer = new ChromePdfRenderer();

// Rendering URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Exporting PDF as Stream
MemoryStream pdfAsStream = pdf.Stream;

// Exporting PDF as Byte Array
byte[] pdfAsByte = pdf.BinaryData;
```

---

## Serving a PDF from Memory on the Web

When you need to serve or export a PDF over the web, the PDF file should be sent as binary data rather than HTML. Further details can be found in this [guide on exporting and saving PDF documents in C#](https://ironpdf.com/how-to/export-save-pdf-csharp/).

Here are quick examples for both MVC and ASP.NET:

### Exporting a PDF with MVC

The code snippet below demonstrates how to serve a PDF file in an MVC application. The binary data for the PDF is contained within a stream, and the MIME type of the response is set to 'application/pdf', with the filename indicated as 'download.pdf'.

```csharp
using System.Web.Mvc;
using System.IO;

public ActionResult ExportPdf()
{
    // Assume pdfAsStream is a MemoryStream with PDF data
    MemoryStream pdfAsStream = new MemoryStream();

    return new FileStreamResult(pdfAsStream, "application/pdf")
    {
        FileDownloadName = "download.pdf"
    };
}
```

### Exporting a PDF with ASP.NET

This example is similar to the MVC version where the PDF data is sent as binary data using ASP.NET. The response is set up and then flushed to ensure the data reaches the client.

```csharp
using System.IO;
using System.Web;

public class PdfHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        // Assume pdfAsStream is a MemoryStream with PDF data
        MemoryStream pdfAsStream = new MemoryStream();

        context.Response.Clear();
        context.Response.ContentType = "application/octet-stream";
        context.Response.OutputStream.Write(pdfAsStream.ToArray(), 0, (int)pdfAsStream.Length);
        context.Response.Flush();
    }

    public bool IsReusable => false;
}
```