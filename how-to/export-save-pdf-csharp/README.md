# C# Export to PDF [Code Example Tutorial]

IronPDF serves as a [C# PDF Library](https://ironpdf.com/use-case/csharp-pdf-library/) that enables the conversion of HTML to PDF using C#. Additionally, it provides functionalities for C# and VB developers to programmatically modify PDF documents.

## Options for Saving PDFs

### Saving PDFs to Disk

The [PdfDocument.SaveAs](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) method allows you to write your PDF file directly to disk. This function also supports password protection capabilities. For detailed guidance on digitally signing your PDFs, refer to the [Digitally Sign a PDF Document](https://ironpdf.com/how-to/signing/) article.

### Saving a PDF File to MemoryStream in C# (`System.IO.MemoryStream`)

The [IronPdf.PdfDocument.Stream](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) property facilitates saving the PDF into a `System.IO.MemoryStream` within memory.

### Exporting to Binary Data

Utilizing the [IronPdf.PdfDocument.BinaryData](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) property, a PDF document can be exported as binary data. This output format is represented as a byte array (`byte[]`) in C#.

### Serving PDFs from a Web Server to Browser

When serving a PDF from a web server, it is transmitted as binary data rather than HTML.

#### MVC PDF Export

```cs
// The MyPdfDocument.Stream object is passed into this method
return new FileStreamResult(stream, "application/pdf")
{
    FileDownloadName = "file.pdf"
};
```

#### ASP.NET PDF Export

```cs
byte[] Binary = MyPdfDocument.BinaryData;
Response.Clear();
Response.ContentType = "application/octet-stream";
Context.Response.OutputStream.Write(Binary, 0, Binary.Length);
Response.Flush();
```