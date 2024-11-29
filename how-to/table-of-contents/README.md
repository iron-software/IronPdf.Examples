# How to Add a Table of Contents

***Based on <https://ironpdf.com/how-to/table-of-contents/>***


A table of contents (TOC) serves as a detailed guide, allowing readers to effortlessly navigate through the sections of a PDF document. Usually positioned at the start, it enumerates the principal sections or chapters along with their corresponding starting pages. This feature enables users to swiftly locate and access specific sections within the document.

IronPDF supports the creation of a navigable table of contents for PDF documents, automatically linking to elements like `h1`, `h2`, `h3`, `h4`, `h5`, and `h6`. The integrated style of the table of contents ensures it does not interfere with existing styles in the HTML content.

## Example: Adding a Table of Contents

The `TableOfContents` property within IronPDF allows you to incorporate a table of contents in your PDF. This property can be set to one of three `TableOfContentsTypes`:
- `None`: No table of contents is created.
- `Basic`: Generates a table of contents without including page numbers.
- `WithPageNumbers`: Produces a table of contents that includes page numbers for each section.

For a practical demonstration, you can download a sample HTML file through the following link:
- [Download the sample HTML file](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/tableOfContent.html)

### Code Example

```cs
using System.IO;
using IronPdf;
namespace IronPdf.TableOfContents
{
    public class Example
    {
        public void Execute()
        {
            // Initialize the PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set rendering options to include the table of contents with page numbers
            renderer.RenderingOptions = new ChromePdfRenderOptions
            {
                TableOfContents = TableOfContentsTypes.WithPageNumbers
            };
            
            // Render the HTML file to a PDF document
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableOfContent.html");
            
            // Save the PDF file
            pdf.SaveAs("tableOfContents.pdf");
        }
    }
}
```

### Visualizing the PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/tableOfContents.pdf#view=75%&page=2" width="100%" height="500px">
</iframe>

The generated table of contents will automatically include hyperlinks to each header tag, from `h1` to `h6`.

**Note:** Using the `Merge` method on the document will disrupt the hyperlinks in the table of contents.

## Placement of the Table of Contents in the PDF

1. Your HTML document should contain proper header tags from `h1` to `h6`.
2. Optionally, you can specify where the table of contents should appear by including a `div` with the ID `ironpdf-toc`. If this `div` is not present, IronPDF will automatically place the table of contents at the beginning of the document.
3. Set the `RenderingOptions` to render the table of contents either with or without page numbers according to your preference.

## Customizing the Table of Contents' Style

The appearance of the table of contents can be customized using CSS. For advanced customization, you can use the `CustomCssUrl` property to link to an external CSS file. Start by downloading the baseline CSS for the table of contents:

- [Download the custom CSS file](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/custom.css)

### Styling Code Example

```cs
using System.IO;
using IronPdf;
namespace IronPdf.TableOfContents
{
    public class StylingExample
    {
        public void Execute()
        {
            // Initialize the renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure options to include custom styles and the table of contents
            renderer.RenderingOptions = new ChromePdfRenderOptions
            {
                TableOfContents = TableOfContentsTypes.WithPageNumbers,
                CustomCssUrl = "./custom.css"
            };
            
            // Read HTML and generate PDF
            string html = File.ReadAllText("tableOfContent.html");
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Save the styled PDF
            pdf.SaveAs("styledTableOfContents.pdf");
        }
    }
}
```

### Specific Styling Adjustments

Target different levels of headers within the table of contents to apply varied styling effects using CSS selectors like `#ironpdf-toc ul li.h1` for H1 headers.

```css
#ironpdf-toc ul li.h1 {
	font-style: italic;
	font-weight: bold;
}
```

### Altering Font Families

Adjust font families for different parts of the table of contents using appropriate CSS properties. Here is how to implement a custom 'Lemon' font, downloadable through the link below:

- [Download the Lemon font](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/Lemon-Regular.ttf)

Implement font changes in CSS:

```css
#ironpdf-toc li .title {
    order: 1;
    font-family: cursive;
}

@font-face {
    font-family: 'lemon';
    src: url('Lemon-Regular.ttf')
}

#ironpdf-toc li .page {
    order: 3;
    font-family: 'lemon', sans-serif;
}
```

### Customizing Indentation and Decorative Lines

Control indentation using the `:root` selector and customize the separator lines within the table of contents to enhance readability:

```css
:root {
	--indent-length: 25px;
}

#ironpdf-toc li::after {
    background-image: radial-gradient(circle, transparent 1px, transparent 1.5px);
    background-position: bottom;
    background-size: 1ex 4.5px;
    background-repeat: space no-repeat;
    content: "";
    flex-grow: 1;
    height: 1em;
    order: 2;
}
```