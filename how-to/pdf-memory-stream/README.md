# MemoryStream to PDF in C#

***Based on <https://ironpdf.com/how-to/pdf-memory-stream/>***


In C# .NET, it's entirely feasible to manipulate MemoryStream objects to handle PDF files without resorting to file system interactions. The `System.IO` namespace in .NET provides the `MemoryStream` object necessary for these operations. In this guide, we explore how to convert HTML to PDF within your C# project using a MemoryStream.

<hr class="separator">

## Creating a PDF from Memory

Within the .NET environment, a `IronPdf.PdfDocument` instance can be created using any of the following in-memory objects:

- `MemoryStream`
- `FileStream`
- `byte[]` (Binary Data)

Consider the following scenario where a URL is read directly into a stream, which is then utilized to save a PDF file to disk using C#:

```cs
using System.IO;
using IronPdf;

namespace ironpdf.PdfMemoryStream
{
    public class Section1
    {
        public void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();

            // Converts a URL to a PDF file
            Uri url = new Uri("https://ironpdf.com/how-to/pdf-memory-stream/");
            
            MemoryStream pdfAsStream = renderer.RenderUrlAsPdf(url).Stream; // Stores the PDF in a stream
        }
    }
}
```

<hr class="separator">

## Writing a PDF to Memory

A `IronPdf.PdfDocument` can be committed directly to memory using the following methods:

- [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) offers a way to get the PDF as a `System.IO.MemoryStream`.
- [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) provides the PDF as a binary array (`byte[]`).

<hr class="separator">

## Delivering a PDF over the Web from Memory

When aiming to deliver a PDF over the web, the PDF data should be transmitted as binary data rather than HTML. Additional details are available in this [comprehensive guide on exporting and storing PDF documents in C#](https://ironpdf.com/how-to/export-save-pdf-csharp/).

Below are concise examples for MVC and ASP.NET:

### Serving a PDF in an MVC Application

In this example, a stream containing binary data from IronPDF is set to be delivered as a response with MIME type 'application/pdf', and the file is named 'downloadedfile.pdf':

```cs
return new FileStreamResult(pdfAsStream, "application/pdf")
{
    FileDownloadName = "downloadedfile.pdf"
};
```

### Serving a PDF in ASP.NET

This scenario is similar to the MVC example, where the stream is the binary data from IronPDF. Here, the response is prepared and flushed to ensure correct delivery to the client:

```cs
Response.Clear();

Response.ContentType = "application/octet-stream";

Context.Response.OutputStream.Write(pdfAsStream, 0, pdfAsStream.Length); // Ensure correct length parameter

Response.Flush();
```