# How to Add Headers and Footers

***Based on <https://ironpdf.com/how-to/headers-and-footers/>***


Do you need to insert page numbers, your company's logo, or the date on every page of a PDF document? Adding headers and footers is the solution, and with IronPDF, it's incredibly easy to do so in your C# projects.

## Quickstart: Add Headers and Footers to PDFs in C#

Quickly and efficiently enhance your PDF documents by adding headers and footers using IronPDF in your C# applications. This brief guide will demonstrate how to implement text-based headers and footers, including page numbers and custom text. Leverage the `AddTextHeaders` and `AddTextFooters` methods for rapid enhancements, ensuring a polished look for your documents with minimal code. This is ideal for developers who need a quick solution for document formatting using IronPDF.

```cs
:title=Implementing a header and footer in a single step!
new IronPdf.ChromePdfRenderer { RenderingOptions = { TextHeader = new IronPdf.TextHeaderFooter { CenterText = "Report • {date}" }, TextFooter = new IronPdf.TextHeaderFooter { RightText = "Page {page} of {total‑pages}" } } }
    .RenderHtmlAsPdf("<h1>Hello World!</h1>")
    .SaveAs("withHeadersFooters.pdf");
```

## Example: Adding Text Headers and Footers

To add a text-based header or footer, create a `TextHeaderFooter` object, customize your text, and integrate it into your PDF.

```cs
using IronPdf;
// Initialize renderer and generate PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Define text header
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Define text footer
TextHeaderFooter textFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Attach text header and footer to the PDF
pdf.AddTextHeaders(textHeader);
pdf.AddTextFooters(textFooter);

pdf.SaveAs("addTextHeaderFooter.pdf");
```

You can also directly incorporate a header and footer using the rendering options of the renderer.

```cs
using IronPdf;
// Initialize renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Setup text header
renderer.RenderingOptions.TextHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Setup text footer
renderer.RenderingOptions.TextFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Generate PDF with header and footer
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
pdf.SaveAs("renderWithTextHeaderFooter.pdf");
```

## Customize Text and Divider Properties

Modify text position, font, size, and add a custom-colored divider using properties in the `TextHeaderFooter` class.

```cs
using IronPdf;
using IronPdf.Font;
using IronSoftware.Drawing;

// Establish text header settings
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "Center text", // Text in the center
    LeftText = "Left text", // Text on the left
    RightText = "Right text", // Text on the right
    Font = IronSoftware.Drawing.FontTypes.ArialBoldItalic, // Font style
    FontSize = 16, // Font size
    DrawDividerLine = true, // Activate a divider line
    DrawDividerLineColor = Color.Red, // Color of the divider line
};
```

#### Output Text Header

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/textheaderfooter-options.webp" alt="Text Header" class="img-responsive add-shadow">
    </div>
</div>

Check available font types in the <a href="https://ironpdf.com/object-reference/api/IronSoftware.Forms.IFormField.html">IronPDF API Reference</a>.

## Set Margins for Text Header/Footer

Set margins for text headers and footers to customize their layout, accommodating the entire width of the PDF if needed.

```cs
using IronPdf;

// Instancing the renderer and creating a PDF
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

pdf.AddTextHeaders(header, 35, 30, 25); // Specify margin values in mm
pdf.AddTextFooters(footer, 35, 30, 25);
```

If you define margin settings via `RenderingOptions` of `ChromePdfRenderer`, they apply to both header and footer.

```cs
using IronPdf;

// Initialize renderer and create PDF document
ChromePdfRenderer renderer = new ChromePdfRenderer();

TextHeaderFooter header = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

TextHeaderFooter footer = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Margin configuration in mm
renderer.RenderingOptions.MarginRight = 30;
renderer.RenderingOptions.MarginLeft = 30;
renderer.RenderingOptions.MarginTop = 25;
renderer.RenderingOptions.MarginBottom = 25;

// Integrate header and footer via renderer
renderer.RenderingOptions.TextHeader = header;
renderer.RenderingOptions.TextFooter = footer;

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
```

The `UseMarginsOnHeaderAndFooter` option doesn't suit this setup since it applies uniform margins, which could overlap the header with the main content. Instead, alongside predefined methods, implement Dynamic Margin Sizing, which adjusts header and footer based on their content.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    HtmlFragment = @"<div style='background-color: #4285f4; color: white; padding: 15px; text-align: center;'>
                    <h1>Example header</h1> <br>
                    <p>Header content</p>
                    </div>",
    // Activate dynamic height adjustment
    MaxHeight = HtmlHeaderFooter.FragmentHeight,
};

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
pdf.SaveAs("dynamicHeaderSize.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/dynamicHeaderSize.pdf" width="100%" height="300px">
</iframe>

## Metadata to Text Header/Footer

Enhance your PDFs by embedding useful metadata like page numbers, dates, and titles through placeholder strings.

- `{page}`: Displays the current page number.
- `{total-pages}`: Shows the total number of pages.
- `{url}`: Indicates the webpage URL from which the PDF was generated.
- `{date}`: Displays the current date.
- `{time}`: Shows the current time.
- `{html-title}`: The title from the HTML's `title` tag.
- `{pdf-title}`: The title defined in the PDF metadata.

For details about `{page}` and `{total-pages}`, refer to the [IronPDF Page Numbers Guide](https://ironpdf.com/how-to/page-numbers/).

```cs
using IronPdf;

// Set up header and footer
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

## Implement HTML Headers and Footers

For enhanced customization and styling, opt for HTML headers and footers. Both approaches have their pros and cons, with text being quicker to render and HTML offering more design flexibility.

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
        <link rel='stylesheet' href='style.css'>
    </head>
    <body>
        <h1>This is a footer!</h1>
    </body>
    </html>";

// Initialize the renderer and create a PDF with HTML headers and footers
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configuration for header and footer
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

// Render and save PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
```

Explore more possibilities in creating and customizing PDFs with our comprehensive [Create PDFs tutorial](https://ironpdf.com/tutorials/csharp-create-pdf-complete-tutorial/).