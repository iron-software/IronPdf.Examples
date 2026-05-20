# C# PDF Library: UTF-8 and HTML Encoding

***Based on <https://ironpdf.com/how-to/encoding/>***


## Quickstart: Convert HTML to PDF with UTF-8 Encoding

IronPDF offers a streamlined approach to converting HTML documents into PDFs, supporting UTF-8 encoding to ensure accurate character representation and exceptional output quality. This guide is perfect for developers who need to quickly integrate PDF generation into their applications.

```cs
:title=Effortless UTF-8 Encoding in a Single Step!
new IronPdf.ChromePdfRenderer { RenderingOptions = { InputEncoding = System.Text.Encoding.UTF8 } }
    .RenderHtmlAsPdf("<html><head><meta charset=\"utf-8\"/></head><body>こんにちは世界</body></html>")
    .SaveAs("unicode.pdf");
```

## Implementing UTF-8 Encoding in HTML to PDF Conversion

When utilizing IronPDF, it's essential to handle extended character sets such as UTF-8 Encoding effectively.

For impeccable HTML to PDF encoding, consider applying the charset in two critical points:

1. Within the `ChromePdfRenderer.RenderingOptions` via `System.Text.Encoding`
2. Directly in your HTML's head section

Align these settings to achieve optimal results:

```csharp
// Instantiate the ChromePdfRenderer class
var renderer = new IronPdf.ChromePdfRenderer();

// Apply UTF-8 as the input encoding in rendering settings
renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8; // default setting

// Convert HTML into a PDF document
using var pdf = renderer.RenderHtmlAsPdf(@"
<html>
    <head>
        
        <meta charset='utf-8'>
    </head>
    <body>こんにちは世界</body>
</html>
");
```

This method ensures consistency not only in your main document content but also in headers and footers.

## Supported Encodings

IronPDF is versatile, supporting all character encoding types that Google Chrome can handle. This includes UTF-16, ISO-8859-1, and Windows-1252.

For detailed insights into IronPDF's capabilities for accurate text rendering in PDFs, refer to [IronPDF's Character Encoding Support](https://ironpdf.com/docs/advanced/character-encoding/).