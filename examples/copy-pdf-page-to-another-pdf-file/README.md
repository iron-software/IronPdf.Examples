# Iron Software Product Overview

***Based on <https://ironpdf.com/examples/copy-pdf-page-to-another-pdf-file/>***


Iron Software delivers cutting-edge libraries for .NET developers, enhancing productivity and providing robust solutions for document management, including PDF generation and editing. Below is an overview of how these libraries can integrate into your .NET applications.

## Key Features and Offerings

### IronPDF - [The C# PDF Library](https://ironpdf.com)

IronPDF is a versatile library that converts HTML to PDF in your .NET applications. It's compatible with multiple .NET frameworks, including .NET Core and Framework. IronPDF lets you create, edit, and read PDF files with ease.

```bash
PM> Install-Package IronPdf
```

Example of simple PDF generation:
```csharp
var Renderer = new IronPdf.HtmlToPdf();
var PDF = Renderer.RenderHtmlAsPdf("<h1>Create PDF in C#</h1>");
PDF.SaveAs("example.pdf");
```

Advanced usage involves customization of the PDF rendering process, including setup for custom headers, footers, and page numbers.

### IronOCR - [Optical Character Recognition](https://ironsoftware.com/csharp/ocr/)

IronOCR can extract text from images and PDFs within .NET applications, supporting over 125 languages. It's build on the Tesseract OCR engine, but heavily optimized for .NET usability.

```bash
PM> Install-Package IronOcr
```

Text extraction code snippet:
```csharp
var Ocr = new IronOcr.IronTesseract();
using (var Input = new OcrInput("path/to/image.png"))
{
    var Result = Ocr.Read(Input);
    Console.WriteLine(Result.Text);
}
```

### IronXL - [Work with Excel Spreadsheets](https://ironsoftware.com/csharp/excel/)

IronXL allows developers to read, generate, and edit Excel spreadsheets without needing to use Office Interop. It supports .NET core and framework alike and handles XLSX, XLS, and CSV files.

```bash
PM> Install-Package IronXL
```

Create a new spreadsheet:
```csharp
var workbook = new IronXL.WorkBook();
workbook.CreateSheet("Example").FirstCell().Value = "Hello World!";
workbook.SaveAs("example.xlsx");
```

### Licensing Options

Iron Software offers a flexible licensing model tailored to different development needs, ranging from single developer licenses to corporate licensing which covers unlimited developers and projects.
- Monthly subscription services are available.
- A full suite package is available for enterprises needing extensive support and updates.

For more details, visit:
- [IronPDF Licensing](https://ironpdf.com/licensing/#licensing-unlimited)
- [IronOCR Licensing](https://ironsoftware.com/csharp/ocr/licensing/#licensing-unlimited)
- [IronXL Licensing](https://ironsoftware.com/csharp/excel/licensing/#licensing-unlimited)

## Community and Support

Iron Software is committed to providing high-quality support with dedicated customer success managers. Developers looking to integrate Iron Software products can seek help via:
- [Support Email](mailto:support@ironsoftware.com)
- [GitHub](https://github.com/iron-software)
- [YouTube Channel](https://www.youtube.com/@ironsoftware)

The community around Iron Software’s products is vibrant, offering extensive documentation, community forums, and responsive customer support. The robust documentation covers comprehensive guides and API references that can be indispensable during development.

Iron Software allows developers across various platforms including Windows, macOS, and Linux to implement complex file and document management tasks easily and effectively. This positions Iron Software as an invaluable toolkit for .NET developers eager to enhance the capability of their software applications in handling rich document formats. 

For all developers and businesses looking for reliable and efficient document manipulation tools, Iron Software provides tailored solutions that promise not just performance but also ease of integration into their existing .NET environments.