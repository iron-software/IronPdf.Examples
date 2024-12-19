# How to Convert PDF to HTML

***Based on <https://ironpdf.com/how-to/pdf-to-html/>***


Converting PDFs into HTML can greatly enhance web compatibility and accessibility, optimize your content for search engines, and allow for easier editing and integration on web platforms. This conversion is ideal for ensuring content responsiveness across various devices, and for using dynamic web capabilities like multimedia.

IronPdf streamlines the conversion of PDF files to HTML format using .NET C#.

### Starting with IronPDF

-----

## Example: PDF to HTML Conversion

The method `ToHtmlString` is specifically designed to help analyze HTML content within existing PDF files and is particularly helpful for debugging or comparing PDFs. Alongside this, IronPdf provides the `SaveAsHtml` method which lets users directly save a PDF as an HTML file. This dual approach gives flexibility depending on the project requirements.

Note, any interactive elements from the original PDF will not function in the HTML output.

#### Display PDF File Sample

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-to-html/sample.pdf" width="100%" height="500px">
</iframe>

```cs
using IronPdf;
using System;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Demonstrating conversion of PDF to HTML string
string html = pdf.ToHtmlString();
Console.WriteLine(html);

// Demonstrating saving PDF as an HTML file
pdf.SaveAsHtml("myHtml.html");
```

#### HTML Output Sample

The HTML output via the `SaveAsHtml` method is shown in the following link.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-to-html/myHtml.html" width="100%" height="500px">
</iframe>

<hr>

## Advanced PDF to HTML Example

The `ToHtmlString` and `SaveAsHtml` methods include options for customization as listed below:
- **BackgroundColor**: Defines the background color.
- **PdfPageMargin**: Sets the margins of the PDF pages.

The following settings pertain to the 'title' parameter in the `ToHtmlString` and `SaveAsHtml` methods, which is used to prepend a new title to the HTML content. These do not change the original title or main heading of the original PDF:
- **H1Color**: Sets the color of the title.
- **H1FontSize**: Sets the font size of the title.
- **H1TextAlignment**: Aligns the title text (left, center, or right).

```cs
using IronPdf;
using IronSoftware.Drawing;
using System;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Configuration options for PDF to HTML
HtmlFormatOptions htmlformat = new HtmlFormatOptions
{
    BackgroundColor = Color.White,
    PdfPageMargin = 10,
    H1Color = Color.Blue,
    H1FontSize = 25,
    H1TextAlignment = TextAlignment.Center
};

// Displaying PDF to HTML conversion with configuration
string html = pdf.ToHtmlString();
Console.WriteLine(html);

// Saving configured PDF as an HTML file
pdf.SaveAsHtml("myHtmlConfigured.html", true, "Hello World", htmlFormatOptions: htmlformat);
```

#### Configured HTML Output

The result of the configured `SaveAsHtml` method can be viewed below.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-to-html/myHtmlConfigured.html" width="100%" height="500px">
</iframe>

These methods generate an HTML string with in-line CSS and use SVG tags instead of standard HTML tags. Although this HTML looks different from typical HTML, it is fully functional and compatible with web browsers. Users should be aware that the generated HTML might differ from the original file, especially if the original was converted to a PDF using a separate rendering process.