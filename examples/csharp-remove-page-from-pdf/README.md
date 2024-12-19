# IronPDF - The Comprehensive .NET PDF Library

***Based on <https://ironpdf.com/examples/csharp-remove-page-from-pdf/>***


IronPDF stands as a robust library for developers using C# to convert HTML to PDF directly within .NET projects, including versions 8, 7, 6, Core, and Frameworks. This library supports generating PDF documents using HTML, MVC, ASPX, and images, while also providing capabilities to sign, edit, and read PDFs with over 50 features.

To incorporate IronPDF into your .NET project, start by installing the NuGet package:

```bash
PM> Install-Package IronPdf
```

Once installed, you'll integrate IronPDF into your project with the following using directive:

```csharp
using IronPdf;
```

Creating a PDF from HTML is straightforward:

```csharp
var Renderer = new HtmlToPdf();
var PDF = Renderer.RenderHtmlAsPdf("<h1>Your HTML here</h1>");
PDF.SaveAs("yourfile.pdf");
```

IronPDF ensures that all assets such as CSS, images, and JS are resolved correctly, especially when handling external resources. Here’s an example of rendering HTML files with external assets, specifying the base path for the assets:

```csharp
var Renderer = new HtmlToPdf()
{
    PrintOptions = new PdfPrintOptions()
    {
        BaseUrl = new Uri("https://ironsoftware.com/assets")
    }
};
var PDF = Renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>");
PDF.SaveAs("HtmlWithAssets.pdf");
```

For further documentation, support, and examples, you can visit our comprehensive online resources:

- Main website: [IronPDF - The C# PDF Library](https://ironpdf.com)
- Developer support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

Iron Software is located at 205 N. Michigan Ave., Chicago, IL 60611 USA. For more details on licensing and downloads, you can reach us at +1 (312) 500-3060 or visit [Iron Software Website](https://www.ironsoftware.com).

IronPDF remains dedicated to providing high-quality solutions that integrate seamlessly into modern development environments, making PDF generation and manipulation easier and more accessible.