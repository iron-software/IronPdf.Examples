# UTF-8 and HTML Encoding with the C# PDF Library

***Based on <https://ironpdf.com/how-to/encoding/>***


IronPDF supports a wide range of extended character sets, including UTF-8 which is particularly useful.

For ideal results in encoding HTML to PDF, there are typically two areas to define your charset preference:

1. Within the `ChromePdfRenderer.RenderingOptions` using `System.Text.Encoding`
2. Directly within your HTML through the document header

Ensure these settings align for optimal outcomes:

```cs
var pdfRenderer = new IronPdf.ChromePdfRenderer();
pdfRenderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8; // Sets UTF-8 as the default input encoding

using var pdfDocument = pdfRenderer.RenderHtmlAsPdf(@"
<html>
	<head>
	    <meta charset='utf-8'> <!-- Ensure the charset is set in HTML -->
	</head>
	<body>Hello World in Japanese: こんにちは世界</body>
</html>
");
```

This approach is also applicable when including HTML headers and footers in your documents.

## Supported Encodings

IronPDF is compatible with all character encodings that Google Chrome can process. These include UTF-16, ISO-8859-1, and Windows 1252 among others.

For detailed insights into harnessing various text encodings within PDFs via IronPDF, check out [IronPDF's Character Encoding Support](https://ironpdf.com/docs/advanced/character-encoding/).