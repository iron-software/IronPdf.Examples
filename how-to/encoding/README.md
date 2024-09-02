# UTF-8 and HTML Encoding Practices with IronPDF's C# Library

When utilizing IronPDF, it's common to engage with a variety of character sets, including UTF-8 encoding.

For flawless reproduction of HTML content into PDF format, it’s crucial to specify your preferred character set in two specific areas:

1. Within the `ChromePdfRenderer.RenderingOptions` through the use of `System.Text.Encoding`.
2. Directly within your HTML document's header.

Ensuring consistency between these settings will yield optimal outcomes:

```cs
var renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8; // Set as default

using var pdf = renderer.RenderHtmlAsPdf(@"
<html>
	<head>
		<meta charset='utf-8'>
	</head>
	<body>Hello World in Japanese: こんにちは世界</body>
</html>
");
```

Note, the above technique is equally applicable to specifying encodings for HTML headers and footers.

## Supported Encodings

IronPDF harnesses the same range of character encodings as Google Chrome, including but not limited to UTF-16, iso8859-1, and Windows 1252.