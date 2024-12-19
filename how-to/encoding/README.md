# UTF-8 and HTML Encoding Techniques with the C# PDF Library

***Based on <https://ironpdf.com/how-to/encoding/>***


When utilizing IronPDF for PDF generation, it's common to encounter various character sets, including UTF-8 Encoding.

To achieve flawless encoding of your HTML into a PDF, there are two key areas where specifying your chosen charset is crucial:

1. Within `ChromePdfRenderer.RenderingOptions` using `System.Text.Encoding`.
2. In the HTML document's header.

For optimal results, ensure these settings align:

```cs
var pdfRenderer = new IronPdf.ChromePdfRenderer();
pdfRenderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8; // This is set to UTF-8 by default

using var document = pdfRenderer.RenderHtmlAsPdf(@"
<html>
	<head>
	    <meta charset='utf-8'>
	</head>
	<body>こんにちは世界</body>
</html>
");
```

This method is equally effective for encoding headers and footers in HTML.

## Supported Encodings

IronPDF is equipped to handle any character encoding that Google Chrome supports, including UTF-16, ISO-8859-1, and Windows-1252.

For further details on how IronPDF accurately renders text in PDFs across different encodings, please visit [IronPDF's Character Encoding Support](https://ironpdf.com/docs/advanced/character-encoding/).