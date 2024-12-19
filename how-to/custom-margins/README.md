# Adjusting Custom Margins with IronPDF

***Based on <https://ironpdf.com/how-to/custom-margins/>***


Creating documents with specific margin requirements is essential, particularly when adhering to formats such as MLA and APA or specific academic guidelines that might dictate unique margin sizes, such as 1-inch for common formats and possibly 1.5 inches for certain thesis standards. 

IronPDF offers a straightforward method to customize margins when you are converting HTML to PDF, ensuring you can meet any document layout requirement with minimum effort.

<h3>Getting Started with IronPDF</h3>

---

## Example: Setting Custom Margins

Let's begin by creating an instance of the `ChromePdfRenderer` class. This class provides access to the `RenderingOptions` object, where you can detail individual margins in millimeters for the top, bottom, left, and right sides as demonstrated below:

```cs
ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.MarginTop = 40;
renderer.RenderingOptions.MarginLeft = 20;
renderer.RenderingOptions.MarginRight = 20;
renderer.RenderingOptions.MarginBottom = 40;
```

These settings add to any margins defined in the HTML’s style section. For example, if the initial HTML margins are set to 50 mm for all sides, applying `RenderingOptions` with an additional 30 mm will extend each margin to 80 mm:

```cs
const string htmlWithStyle = @"
<!DOCTYPE html>
<html>
    <head>
        <style>
            body {margin: 50mm 50mm 50mm 50mm;}
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

View the resulting PDF here:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-margins/PdfWithCustomMargins.pdf" width="100%" height="500px"></iframe>

## Customizing Margins in Headers and Footers

By default, the margins defined in `RenderingOptions` do not affect the header and footer sections of your document. To apply your custom margins consistently throughout the document, including the headers and footers, adjust the `UseMarginsOnHeaderAndFooter` property in the `RenderingOptions`:

```cs
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
```

You can also specify granular control over which margins to use in headers and footers. Further details and other configurations can be found in our detailed [API Documentation](https://ironpdf.com/object-reference/api/IronPdf.UseMargins.html). Here are a couple of configuration examples:

```cs
// Apply only the left margin to the header and footer.
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;

// Apply only the left and right margins to the header and footer.
renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
```