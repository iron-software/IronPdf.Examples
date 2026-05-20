# C# Export to PDF Code Example Tutorial

***Based on <https://ironpdf.com/how-to/export-save-pdf-csharp/>***


IronPDF is a robust [C# PDF Library](https://ironpdf.com/use-case/csharp-pdf-library/) designed for developers using C# to convert HTML into PDF files. It also provides functionalities for editing PDF documents in both C# and VB.

## Quickstart: Export HTML to PDF in C# with IronPDF

Seamlessly convert your HTML to PDF in C# with IronPDF. This easy-to-follow guide demonstrates how to change HTML into a PDF file and how to save it with minimal coding. IronPDF simplifies the process of PDF creation, making it straightforward for developers to embed PDF exporting capabilities in their applications effortlessly. Let's explore how easy it is to start!

```cs
:title=Quick and Easy PDF Export
new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Welcome to PDF</h1>").SaveAs("resultingPDF.pdf");
```

## Options for Saving PDFs

### Storing PDFs on Disk

When looking to store your PDF files on disk, utilize the [`PdfDocument.SaveAs`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) method. This option also offers features like password protection. For more details on digital signatures on PDFs, refer to the guide on '[Digitally Sign a PDF Document](https://ironpdf.com/how-to/signing/).'

### Saving a PDF to MemoryStream in C# (`System.IO.MemoryStream`)

The property [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) enables saving the PDF directly to memory, employing a `System.IO.MemoryStream`.

### Binary Data Storage

To save the PDF as binary data, refer to the [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) property. This method returns the document as a byte array, or `byte[]` in C#.

### Web Server PDF Delivery to Browsers

For online applications, PDFs should be transmitted in binary form.

#### MVC PDF Export

```csharp
// Returns a file stream result, allowing 'stream' to be downloaded by the client.
return new FileStreamResult(stream, "application/pdf")
{
    FileDownloadName = "downloadedFile.pdf"
};
```

#### ASP.NET PDF Export

```csharp
// Access the PDF's binary data
byte[] binaryData = MyPdfDocument.BinaryData;

// Clear any existing content in the response
Response.Clear();

// Specify the type of data in the response
Response.ContentType = "application/octet-stream";

// Output the binary data to the response's stream
Context.Response.OutputStream.Write(binaryData, 0, binaryData.Length);

// Ensure the response is sent to the client
Response.Flush();
```