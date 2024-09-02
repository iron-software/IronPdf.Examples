# MemoryStream to PDF in C#

Leverage the power of the `.NET System.IO` namespace to manipulate PDFs directly from memory without the need to interact with disk storage in C#. This guide explains converting HTML content to PDF using C# with IronPdf.

---

## Instantiating a PDF from Memory

In C#, you can initialize an `IronPdf.PdfDocument` with different in-memory objects like:

- A `MemoryStream`
- A `FileStream`
- Binary data as a byte array (`byte[]`)

Consider this sample where a URL is converted into PDF using a stream, followed by saving the PDF on disk:

```cs
using System;
using System.IO;

var renderer = new IronPdf.ChromePdfRenderer();

// Convert URL to a PDF
Uri url = new Uri("https://ironpdf.com/how-to/pdf-memory-stream/");

MemoryStream pdfAsStream = renderer.RenderUrlAsPdf(url).Stream;  // Obtain the PDF stream
```

---

## Storing a PDF in Memory

To store a `IronPdf.PdfDocument` directly into memory, use:

- [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) for a `System.IO.MemoryStream` output.
- [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) to obtain the output as a byte array (`byte[]`).

---

## Web Delivery of a PDF from Memory

Distribute a PDF on the web by sending the PDF file as binary data. Learn more about saving and exporting PDF documents in C# [here](https://ironpdf.com/how-to/export-save-pdf-csharp/).

### Serving a PDF in MVC

Below is an example where binary data from `IronPDF` is transferred over the web with an MVC application. The response MIME type is set to `application/pdf`, and the file is named 'downloadedfile.pdf'.

```cs
return new FileStreamResult(pdfAsStream, "application/pdf")
{
    FileDownloadName = "downloadedfile.pdf"
};
```

### Serving a PDF in ASP.NET

This example closely resembles the MVC one but uses ASP.NET specifics to configure and dispatch the response:

```cs
Response.Clear();
Response.ContentType = "application/octet-stream";

Context.Response.OutputStream.Write(pdfAsStream, 0, pdfAsStream.Length);

Response.Flush();
```