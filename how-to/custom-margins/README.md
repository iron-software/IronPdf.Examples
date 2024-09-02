# Setting Custom Margins with IronPDF

Managing margin settings is crucial when preparing documents that must meet specific formatting standards, such as those required by academic guidelines like MLA and APA or specific university dissertation requirements.

IronPDF provides a straightforward method to define custom margins when converting HTML to a PDF. This flexibility allows for precise document layout control.

## Example: Adjusting Margins

To start customizing margins, create an instance of the `ChromePdfRenderer` class. This class provides access to the `RenderingOptions` object, where you can specify the exact margins for top, bottom, left, and right in millimeters:

```cs
ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.MarginTop = 40;
renderer.RenderingOptions.MarginLeft = 20;
renderer.RenderingOptions.MarginRight = 20;
renderer.RenderingOptions.MarginBottom = 40;
```

These margin values are additive to any margins defined within the HTML's style attributes. For example, if the HTML has a default 50 mm margin, and you set 30 mm on each side via the `RenderingOptions`, the total margin will sum to 80 mm:

```cs
const string htmlWithStyle = @"
<!DOCTYPE html>
<html>
    <head>
        <style>
            body {margin: 50mm;}
        </style>
    </head>
<body>
    <h1>Hello World!</h1>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.MarginTop = 30;
renderer.RenderingOptions.MarginLeft = 30;
renderer.RenderingOptions.MarginRight = 30;
renderer.RenderingOptions.MarginBottom = 30;

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlWithStyle);
pdf.SaveAs("PdfWithCustomMargins.pdf");
```

To view the resulting PDF, use the following embedded link:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-margins/PdfWithCustomMargins.pdf" width="100%" height="500px"></iframe>

## Customizing Margins in Headers and Footers

By default, `RenderingOptions` does not affect the margins of headers and footers. To apply custom margins to these areas, modify the `UseMarginsOnHeaderAndFooter` property in `RenderingOptions`:

```cs
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
```

You can also select specific margins to apply to headers and footers. Full details are available in our [API Reference](https://ironpdf.com/object-reference/api/IronPdf.UseMargins.html). Here are a couple of examples of how to apply selective margins:

```cs
// Applying only the document's left margin to the header and footer.
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;

// Applying both the left and right margins from the document to the header and footer.
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
```

This flexible system ensures that your documents can meet any layout requirement with ease using IronPDF.