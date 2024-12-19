# MemoryStream to PDF in C&#35;

***Based on <https://ironpdf.com/how-to/pdf-memory-stream/>***


Create, load, and convert `MemoryStream` to PDF files in C# using .NET, without dealing with file system operations. This process utilizes the `MemoryStream` class from the `System.IO` namespace in .NET. Below is a guide on how to convert HTML to PDF in a C# project leveraging IronPDF.

### Introduction to IronPDF

---

---

## Initialize a PDF From Memory

The `IronPdf.PdfDocument` class can be instantiated using any of the following in-memory objects in .NET:

- `MemoryStream`
- `FileStream`
- Binary data represented as a byte array (`byte[]`)

Below is a code snippet that demonstrates reading a URL directly into a stream and subsequently saving the PDF to disk with C#:

```cs
using System;
using System.IO;

// Set up the PDF renderer
var renderer = new IronPdf.ChromePdfRenderer();

// Converting URL into a PDF
Uri url = new Uri("https://ironpdf.com/how-to/pdf-memory-stream/");
MemoryStream pdfAsStream = renderer.RenderUrlAsPdf(url).Stream; // Load PDF stream
```

---

## Store a PDF in Memory

`IronPdf.PdfDocument` offers two methods to save a PDF directly to memory:

- [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) which saves the PDF in a `System.IO.MemoryStream`
- [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) which saves the PDF as a byte array (`byte[]`)

---

## Delivering a PDF through Web from Memory

For web delivery or exporting of a PDF, it's essential to transmit the document as binary data rather than in HTML format. Additional details are available in this [C# PDF export and save guide](https://ironpdf.com/how-to/export-save-pdf-csharp/).

### Serving a PDF via MVC

The following example demonstrates retrieving binary data from `IronPDF` and setting the MIME type to 'application/pdf' to indicate a downloadable PDF.

```cs
return new FileStreamResult(pdfAsStream, "application/pdf")
{
    FileDownloadName = "downloadedfile.pdf"
};
```

### Serving a PDF via ASP.NET

This example mirrors the MVC approach but includes steps to configure and send the response to the client effectively.

```cs
Response.Clear();
Response.ContentType = "application/octet-stream";
Context.Response.OutputStream.Write(pdfAsStream, 0, pdfAsStream.Length);
Response.Flush();
```