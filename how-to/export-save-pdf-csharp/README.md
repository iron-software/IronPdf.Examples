# C# Export to PDF Code Example Tutorial

***Based on <https://ironpdf.com/how-to/export-save-pdf-csharp/>***


IronPDF is a powerful [C# PDF Library](https://ironpdf.com/use-case/csharp-pdf-library/) designed to enable the conversion of HTML to PDF using C#. It also provides functionalities for C# and VB developers to programmatically modify PDF documents.

### Getting Started with IronPDF

---

## Saving PDF Options

### Save PDF to Disk

To save a PDF file to your disk, utilize the [`PdfDocument.SaveAs`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) technique. This function allows you to add password protection to your PDF files. For more details on how to add digital signatures to your PDFs, refer to '[Digitally Sign a PDF Document](https://ironpdf.com/how-to/signing/).'

### Stream PDF to `System.IO.MemoryStream` in C#

The [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) attribute enables saving the PDF to a memory stream using a `System.IO.MemoryStream`.

### Export to Binary Data

Save your PDF document as binary data with the [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) property. This method involves exporting the PDF as a byte array, represented in C# as `byte[]`.

### Serve PDF from Web Server to Browser

To deliver a PDF file directly from a web server to a client's browser using binary data:

#### MVC PDF Delivery

```cs
// Prepare the PDF stream
FileStreamResult result = new FileStreamResult(MyPdfDocument.Stream, "application/pdf")
{
    FileDownloadName = "downloadedFile.pdf"
};
return result;
```

#### ASP.NET PDF Delivery

```cs
byte[] binaryData = MyPdfDocument.BinaryData;
Response.Clear();
Response.ContentType = "application/octet-stream";
Response.OutputStream.Write(binaryData, 0, binaryData.Length);
Response.Flush();
```