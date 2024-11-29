# Adding Headers and Footers to PDFs with IronPDF

***Based on <https://ironpdf.com/how-to/headers-and-footers/>***


Including elements like page numbers, a company logo, or dates on every page of a PDF can be a crucial requirement in many applications. Thanks to IronPDF's capabilities, adding headers and footers in your C# projects is straightforward and efficient.

## Applying Text-Based Headers and Footers

To add text-based headers or footers, initialize a **TextHeaderFooter** instance, fill it with requisite text, and attach it to your PDF document.

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section1
    {
        public void Run()
        {
            // Initialize the PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            
            // Configure the header text
            TextHeaderFooter textHeader = new TextHeaderFooter
            {
                CenterText = "This is the header!",
            };
            
            // Configure the footer text
            TextHeaderFooter textFooter = new TextHeaderFooter
            {
                CenterText = "This is the footer!",
            };
            
            // Append the header and footer to the PDF
            pdf.AddTextHeaders(textHeader);
            pdf.AddTextFooters(textFooter);
            
            // Save the PDF with added headers and footers
            pdf.SaveAs("addTextHeaderFooter.pdf");
        }
    }
}
```

For a more direct approach, you can opt to set headers and footers through the rendering options of the **ChromePdfRenderer**, adding them during the PDF rendering process.

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section2
    {
        public void Run()
        {
            // Create a new PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure the header and footer with the rendering options
            renderer.RenderingOptions.TextHeader = new TextHeaderFooter
            {
                CenterText = "This is the header!",
            };
            
            renderer.RenderingOptions.TextFooter = new TextHeaderFooter
            {
                CenterText = "This is the footer!",
            };
            
            // Render the PDF with the text header and footer included
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            pdf.SaveAs("renderWithTextHeaderFooter.pdf");
        }
    }
}
```

## Customizing Text and Divider Appearance

Within the **TextHeaderFooter** class, you can define text for various positions (left, center, right). Additionally, customize the type and size of the font and insert a divider with a specific color.

```cs
using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section3
    {
        public void Run()
        {
            // Setup a text header with customization
            TextHeaderFooter textHeader = new TextHeaderFooter
            {
                CenterText = "Center text", // Text in the center
                LeftText = "Left text", // Text on the left
                RightText = "Right text", // Text on the right
                Font = IronSoftware.Drawing.FontTypes.ArialBoldItalic, // Font style
                FontSize = 16, // Font size
                DrawDividerLine = true, // Enable divider line
                DrawDividerLineColor = Color.Red, // Divider line color
            };
        }
    }
}
```

#### Sample Text Header

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/textheaderfooter-options.webp" alt="Text Header" class="img-responsive add-shadow">
    </div>
</div>

Explore more about available font options in the [IronPDF API Reference](https://ironpdf.com/object-reference/api/IronSoftware.Forms.IFormField.html).

## Adjusting Margins for Text Headers/Footers

IronPDF ensures familiar handling of text headers and footers including predefined margins. For headers and footers spanning the entire page width, define zero margins.

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section4
    {
        public void Run()
        {
            // Establish the PDF renderer and generate a new PDF
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
            
            // Apply margins to the header and footer
            pdf.AddTextHeaders(header, 35, 30, 25); // Margins measured in mm
            pdf.AddTextFooters(footer, 35, 30, 25); // Margins measured in mm 
        }
    }
}
```

Including margin values directly via the `RenderingOptions` of **ChromePdfRenderer** will apply those margins to headers and footers as well.

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section5
    {
        public void Run()
        {
            // Setup the PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            TextHeaderFooter header = new TextHeaderFooter
            {
                CenterText = "This is the header!",
            };
            
            TextHeaderFooter footer = new TextHeaderFooter
            {
                CenterText = "This is the footer!",
            };
            
            // Define margins
            renderer.RenderingOptions.MarginRight = 30;
            renderer.RenderingOptions.MarginLeft = 30;
            renderer.RenderingOptions.MarginTop = 25;
            renderer.RenderingOptions.MarginBottom = 25;
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
            
            // Include the header and footer in the renderer options
            renderer.RenderingOptions.TextHeader = header;
            renderer.RenderingOptions.TextFooter = footer;
            
            // Render and output the finalized PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
        }
    }
}
```

### Dynamic Margin Adjustment

Addressing static margins and the need for flexibility when header and footer content varies, IronPDF introduces a Dynamic Margin Sizing feature. This allows the header and footer sizes to adjust dynamically based on their content, ensuring the main HTML content is appropriately positioned.

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section6
    {
        public void Run()
        {
            // Set up the renderer
            ChromePdfRenderer renderer = a new ChromePdfRenderer();
            
            // Configure dynamic headers
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                HtmlFragment = @"<div style='background-color: #4285f4; color: white; padding: 15px; text-align: center;'>
                                <h1>Example header</h1><br>
                                <p>Header content</p>
                                </div>",
                MaxHeight = HtmlHeaderFooter.FragmentHeight,
            };
            
            // Render the PDF with dynamic headers
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Main HTML content</h1>");
            pdf.SaveAs("dynamicHeaderSize.pdf");
        }
    }
}

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/headers-and-footers/dynamicHeaderSize.pdf" width="100%" height="300px">
</iframe>

## Incorporating Metadata in Text Headers/Footers

Easily add dynamically updating metadata like page numbers or dates to your headers or footers using placeholders within the text.

- `{page}`: Current page number.
- `{total-pages}`: Total page count.
- `{url}`: URL from which the document is rendered.
- `{date}`: Current date.
- `{time}`: Current time.
- `{html-title}`: HTML `<title>` content.
- `{pdf-title}`: PDF metadata title.

For a deeper dive, consider the [IronPDF Page Numbers Guide](https://ironpdf.com/how-to/page-numbers/).

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section7
    {
        public void Run()
        {
            // Prepare dynamic text for header and footer
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
        }
    }
}
```

## Utilizing HTML for Headers/Footers

For further customization, employ HTML and CSS in your headers and footers using the **HtmlHeaderFooter** class. Ensure styles are retained by setting `LoadStylesAndCSSFromMainHtmlDocument` to `true`.

```cs
using IronPdf;
namespace ironpdf.HeadersAndFooters
{
    public class Section8
    {
        public void Run()
        {
            // Define HTML for header and footer
            string headerHtml = @"
                <html>
                <head>
                    <link rel='stylesheet' href='https://ironpdf.com/style.css'>
                </head>
                <body>
                    <h1>This is a header!</h1>
                </body>
                </html>";
            
            string footerHtml = @"
                <html>
                <head>
                    <link rel='stylesheet' href='https://ironpdf.com/style.css'>
                </head>
                <body>
                    <h1>This is a footer!</h1>
                </body>
                </html>";
            
            // Initialize the renderer and render the PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            
            // Configure and apply the HTML headers and footers
            HtmlHeaderFooter htmlHeader = new HtmlHeaderFooter
            {
                HtmlFragment = headerHtml,
                LoadStylesAndCSSFromMainHtmlDocument = true,
            };
            
            HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter
            {
                HtmlFragment = footerHtml,
                LoadStylesAndCSSFromMainHtmlDocument = true,
            };
            
            // Add the composed elements to the PDF
            pdf.AddHtmlHeaders(htmlHeader);
            pdf.AddHtmlFooters(htmlFooter);
        }
    }
}
```

### Deciding Between Text and HTML Headers/Footers

When deciding between text and HTML headers or footers, weigh the benefits of faster rendering against the need for greater customization and style. The difference in rendering times might not be substantial with simpler HTML, but as content expands, so will the rendering duration.