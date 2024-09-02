# Implementing Headers and Footers in PDFs

If you need to add page numbers, a company logo, or the current date to each page of your PDF, headers and footers make this task easy. Using IronPDF, it's straightforward to append headers and footers within your C# applications.

## Example: Adding a Text-Based Header/Footer

To add a simple text header or footer in your PDF, you can start by creating an instance of the `TextHeaderFooter` class. Here’s how to implement a basic text header and footer:

```cs
using IronPdf;

// Create PDF renderer object
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Define the text header
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Define the text footer
TextHeaderFooter textFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Add the text header and footer to your PDF
pdf.AddTextHeaders(textHeader);
pdf.AddTextFooters(textFooter);

pdf.SaveAs("TextHeadersAndFooters.pdf");
```

Alternatively, the header and footer text can be included during the PDF rendering phase, as shown below:

```cs
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure text header and footer
renderer.RenderingOptions.TextHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};
renderer.RenderingOptions.TextFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Generate the PDF with headers and footers
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
pdf.SaveAs("RenderWithHeadersFooters.pdf");
```

## Customize Text Properties and Divider Appearance

With the `TextHeaderFooter` class, you can set text alignment and style properties, along with dividers to enhance readability:

```cs
using IronPdf;
using IronPdf.Font;
using IronSoftware.Drawing;

// Define a custom text header
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "Center-aligned text",
    LeftText = "Text on the left",
    RightText = "Text on the right",
    Font = FontTypes.ArialBoldItalic,
    FontSize = 16,
    DrawDividerLine = true,
    DrawDividerLineColor = Color.Red,
};

// Displaying the header as it would appear in a PDF
```
![Text Header Configuration](https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/textheaderfooter-options.webp)

For global font settings, refer to the [API documentation](https://ironpdf.com/object-reference/api/IronSoftware.Forms.IFormField.html).

## Managing Margins for Text Headers and Footers

In IronPDF, text headers and footers are set with predefined margins. However, these can be adjusted to span the entire width of the document by setting margin values to zero:

```cs
using IronPdf;

// Setup PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

TextHeaderFooter header = new TextHeaderFooter
{
    CenterText = "Full-width Header",
};

TextHeaderFooter footer = new TextHeaderFooter
{
    CenterText = "Full-width Footer",
};

// Add custom margins to the header and footer
pdf.AddTextHeaders(header, 35, 30, 25);
pdf.AddTextFooters(footer, 35, 30, 25);
```

The renderer margins affect both the header and footer if specified in `RenderingOptions`.

### Dynamic Adjustments for Content-Specific Headers and Footers

IronPDF supports dynamic sizing of headers and footers to accommodate varying content sizes:
```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    HtmlFragment = @"<div style='background-color: #4285f4; color: white; padding: 15px; text-align: center;'>
                    <h1>Example header</h1> <br>
                    <p>Header content</p>
                    </div>",
    MaxHeight = HtmlHeaderFooter.FragmentHeight,
};

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
pdf.SaveAs("DynamicHeaderSize.pdf");
```
<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/dynamicHeaderSize.pdf" width="100%" height="300px">
</iframe>

## Metadata Usage in Text Headers and Footers

Easily include dynamic content such as page numbers or dates by using placeholders in your headers and footers:

- `{page}`: Current page number.
- `{total-pages}`: Total pages.
- `{url}`: Source URL of the PDF document.
- `{date}`, `{time}`: Current date and time.
- `{html-title}`, `{pdf-title}`: Titles from HTML and PDF metadata.

Refer to our [page about adding page numbers](https://ironpdf.com/how-to/page-numbers/) for detailed guidance.

## HTML Based Headers and Footers for Enhanced Customization

HTML headers and footers allow for greater customization using HTML and CSS. Here’s how to achieve this with IronPDF:

```cs
using IronPdf;

string headerHtml = @"
    <html>
    <head>
        <link rel='stylesheet' href='https://ironpdf.com/style.css'>
    </head>
    <body>
        <h1>Custom HTML Header</h1>
    </body>
    </html>";

string footerHtml = @"
    <html>
    <head>
        <link rel='stylesheet' href='https://ironpdf.com/style.css'>
    </head>
    <body>
        <h1>Custom HTML Footer</h1>
    </body>
    </html>";

// Initialize renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Setup HTML header and footer
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter
{
    HtmlFragment = headerHtml,
    LoadStylesAndCSSFromMainHtmlDocument = true,
};

renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = footerHtml,
    LoadStylesAndCSSFromMainHtmlDocument = true,
};

// Generate PDF with custom HTML headers and footers
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Greetings from IronPDF!</h1>");
```

### Choosing Between Text and HTML Headers/Footers

When deciding on the type of header/footer, consider the complexity and style requirements of your document. Text headers and footers are simpler and faster to render, whereas HTML-based ones offer more flexibility and styling options.