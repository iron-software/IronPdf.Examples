# C# Export to PDF Code Example Tutorial

***Based on <https://ironpdf.com/how-to/export-save-pdf-csharp/>***


IronPDF is a [C# PDF Library](https://ironpdf.com/use-case/csharp-pdf-library/) that enables C# developers to convert HTML to PDF format. It also provides functionality for C# and VB developers to modify PDF documents programmatically.

## Methods for Exporting PDFs

### Saving a PDF to Disk

Utilize the [`PdfDocument.SaveAs`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) method to store your PDF files on a local drive.

This functionality includes options for password protection of the PDF files. For additional resources on how to add digital signatures to your documents, refer to '[Digitally Sign a PDF Document](https://ironpdf.com/how-to/signing/).'

### Storing a PDF in a `MemoryStream` in C#

The [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) property allows the storage of the PDF in a `System.IO.MemoryStream`.

### Exporting PDF to Binary Format

The [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) property lets you export and store PDF documents as binary data in memory.

This binary data is represented in C# as an array of bytes, `byte[]`.

### Delivering PDFs from a Web Server to a Browser

When serving PDF files online, deliver them as binary data instead of HTML content.

#### Exporting PDF in MVC

```cs
// Pass MyPdfDocument.Stream to this method to send a PDF file
return new FileStreamResult(stream, "application/pdf")
{
    FileDownloadName = "downloaded-file.pdf"
};
```

#### Exporting PDF in ASP.NET

```cs
byte [] binaryData = MyPdfDocument.BinaryData;
Response.Clear();
Response.ContentType = "application/octet-stream";
Context.Response.OutputStream.Write(binaryData, 0, binaryData.Length);
Response.Flush();      
```