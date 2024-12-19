# How to Add Headers and Footers to PDFs

***Based on <https://ironpdf.com/how-to/headers-and-footers/>***


Interested in adding page numbers, a company logo, or dates to the top or bottom of every page in your PDF document? Headers and footers are perfect for this, and using IronPDF, it's incredibly straightforward to embed these into PDFs within your C# Project.

***

<h3>Begin with IronPDF</h3>

***

## Example: Adding a Text Header/Footer

For a simple text-based header or footer, begin by creating a **TextHeaderFooter** instance, set your preferred text, and attach it to your PDF.

```cs
using IronPdf;

// Create a PDF renderer instance and generate a PDF from HTML
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Construct a text-based header
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Construct a text-based footer
TextHeaderFooter textFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Attach the header and footer to the PDF
pdf.AddTextHeaders(textHeader);
pdf.AddTextFooters(textFooter);

pdf.SaveAs("addTextHeaderFooter.pdf");
```

You can also add headers and footers directly through the rendering options of the renderer, which will include them during the PDF generation process.

```cs
using IronPdf;

// Initialize renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Setup the header and integrate it into the rendering options
renderer.RenderingOptions.TextHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Setup the footer and integrate it into the rendering options
renderer.RenderingOptions.TextFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Generate the PDF with both header and footer included
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
pdf.SaveAs("renderWithTextHeaderFooter.pdf");
```

## Customize Font and Divider Options

The **TextHeaderFooter** allows you to define text for three positions: left, center, and right. Enhance your headers and footers by setting the font type, size, and even a custom-colored divider.

```cs
using IronPdf;
using IronPdf.Fonts;
using IronSoftware.Drawing;

// Set up a text header with custom font and divider *color
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "Center text", // Central text
    LeftText = "Left text", // Left-aligned text
    RightText = "Right text", // Right-aligned text
    Font = IronSoftware.Drawing.FontTypes.ArialBoldItalic, // Font style and weight
    FontSize = 16, // Font size
    DrawDividerLine = true, // Enable divider line
    DrawDividerLineColor = Color.Red, // Divider line color
};
```

#### Output Of Text Header

![Text Header Options](https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/textheaderfooter-options.webp)

For a full overview of available font types, see the [IronPDF API Reference](https://ironpdf.com/object-reference/api/IronSoftware.Forms.IFormField.html).

## Margin Settings for Text Headers and Footers

By default, **TextHeaderFooter** in IronPDF has preset margins. To extend the text header across the full width of the document, you can override these by specifying zero margins. This can be set directly in functions like `AddTextHeaders` and `AddTextFooters` or via **RenderingOptions** in **ChromePdfRenderer**.

```cs
using IronPdf;

// Initialize renderer and create a PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

TextHeaderFooter header = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

TextHeaderFooter footer = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Set custom margins for header and footer (measurements in mm)
pdf.AddTextHeaders(header, 35, 30, 25);
pdf.AddTextFooters(footer, 35, 30, 25);
```

### Dynamic Margin Adjustment

When header and footer sizes change across different documents, it's important to adjust the margins for the main content area as well, to ensure a consistent layout. Therefore, IronPDF includes a Dynamic Margin Sizing feature to automatically adjust header and footer heights based on their content.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Enable dynamic sizing for the header
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    HtmlFragment = @"<div style='background-color: #4285f4; color: white; padding: 15px; text-align: center;'>
                    <h1>Example header</h1> <br>
                    <p>Header content</p>
                    </div>",
    MaxHeight = HtmlHeaderFooter.FragmentHeight,
};

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
pdf.SaveAs("dynamicHeaderSize.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/dynamicHeaderSize.pdf" width="100%" height="300px">
</iframe>

## Metadata Integration with Text Headers and Footers

Enhance your headers and footers with dynamic content such as page numbers, current date, or document titles using placeholder strings.

Here are the available metadata placeholders:
- `{page}`: Current page number.
- `{total-pages}`: Total pages.
- `{url}`: URL of the web page PDF was generated from.
- `{date}`: Current date.
- `{time}`: Current time.
- `{html-title}`: HTML title from the <title> tag.
- `{pdf-title}`: PDF document title.

For details on the metadata placeholders `{page}` and `{total-pages}`, refer to the [IronPDF Page Numbers Guide](https://ironpdf.com/how-to/page-numbers/).

```cs
using IronPdf;

// Initialize header and footer with metadata
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "{page} of {total-pages}",
    LeftText = "Today's date: {date}",
    RightText = "The time: {time}",
};

TextHeaderFooter textFooter = new TextHeaderFooter
{
    CenterText = "Current URL: {url}",
    LeftText = "Title of the HTML: {html-title}",
    RightText = "Title of the PDF: {pdf-title}",
};
```

## Example: Creating an HTML Header/Footer

For more customization, consider using HTML and CSS to design your headers and footers. Create an **HtmlHeaderFooter** instance and ensure CSS styles are retained by setting `LoadStylesAndCSSFromMainHtmlDocument` to `true`.

```cs
using IronPdf;

string headerHtml = @"
    <html>
    <head>
        <link rel='stylesheet' href='style.css'>
    </head>
    <body>
        <h1>This is a header!</h1>
    </body>
    </html>";

string footerHtml = @"
    <html>
    <head>
        <link rel='...