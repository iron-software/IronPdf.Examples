# How to Add a Table of Contents

***Based on <https://ironpdf.com/how-to/table-of-contents/>***


A table of contents (TOC) in a PDF serves as a navigational tool, much like a roadmap that guides readers through the document. It is generally placed at the beginning of the PDF and enumerates the primary sections or chapters along with their starting page numbers. This feature facilitates quick and easy access to different sections of the document, enhancing the reader's ability to efficiently locate information.

IronPDF includes functionality that enables the automatic creation of a table of contents, linking to the 'h1' through 'h6' headings within the document. This TOC is styled by default to ensure it does not interfere with other styles within the HTML source.

<h3> Get Started with IronPDF</h3>

---

## Example: Adding a Table of Contents

To introduce a table of contents in your PDF, utilize the **TableOfContents** property. This property accepts one of three **TableOfContentsTypes** values:
- None: No table of contents is created.
- Basic: Generates a table of contents without page numbers.
- WithPageNumbers: Produces a table of contents that includes page numbers.

For a practical demonstration, consider downloading the provided sample HTML:
- [Download the sample HTML file](https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/tableOfContent.html)

### Implementing the Code

```cs
using IronPdf;
using System.IO;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options, including enabling the TOC
renderer.RenderingOptions = new ChromePdfRenderOptions
{
    TableOfContents = TableOfContentsTypes.WithPageNumbers,  // TOC with page numbers
};

PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableOfContent.html");

pdf.SaveAs("tableOfContents.pdf");
```

### Viewing the Output PDF

<iframe loading="lazy" src="https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/tableOfContents.pdf#view=75%&page=2" width="100%" height="500px">
</iframe>

The TOC will include interactive hyperlinks for each 'h1' through 'h6' heading.

Note: Applying the `Merge` method on the document will disrupt the hyperlinks in the TOC.

<hr>

## Positioning the Table of Contents in the PDF

1. Ensure your HTML document contains proper header tags (h1 to h6).
2. Optionally, place a div for the TOC. Without this div, IronPDF will place the TOC at the beginning by default.
```html
    <div id="ironpdf-toc"></div>
```
3. Decide in the render options whether to include page numbers in the TOC.

<hr>

## Customizing the Table of Contents Style

You can style the Table of Contents using CSS. Start by downloading the default style sheet:
- [Download the custom CSS file](https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/custom.css)

Avoid modifying the `page-break-before` and `page-break-after` CSS properties for the table of contents to ensure accurate page number calculation.

```cs
using IronPdf;
using System.IO;

// Create a PDF renderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Setting render options
renderer.RenderingOptions = new ChromePdfRenderOptions
{
    TableOfContents = TableOfContentsTypes.WithPageNumbers, // Enable TOC with page numbers
    CustomCssUrl = "./custom.css"  // Custom styling
};

// Load and render the HTML as PDF
string html = File.ReadAllText("tableOfContent.html");
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

pdf.SaveAs("tableOfContents.pdf");
```

### Custom Header Styles

Modify the appearance of headers within the TOC by adapting the CSS classes for each header level (from 'h1' to 'h6').

```css
#ironpdf-toc ul li.h1 {
	font-style: italic;
    font-weight: bold;
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/style-headers.webp" alt="Style headers" class="img-responsive add-shadow">
    </div>
</div>

### Changing Font Family

```css
#ironpdf-toc li .title {
    order: 1;
    font-family: cursive;  // Title font style
}

@font-face {
    font-family: 'lemon';
    src: url('https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/Lemon-Regular.ttf')  // Custom font
}

#ironpdf-toc li .page {
    order: 3;
    font-family: 'lemon', sans-serif;  // Page number font style
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/font-family.webp" alt="Set custom font family" class="img-responsive add-shadow">
    </div>
</div>

### Handling Indentation

Control the indent level for each header type using the ':root' CSS selector, adjusting as needed.

```css
:root {
	--indent-length: 25px;  // Specify the indent length
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/indentation.webp" alt="Set custom indentation" class="img-responsive add-shadow">
    </div>
</div>

### Removing Dotted Lines

Customize or remove the dotted lines between header titles and page numbers by altering the ':after' pseudo-element.

```css
#ironpdf-toc li::after {
    background-image: radial-gradient(circle, transparent 1px, transparent 1.5px);  // Modify dot style
    background-position: bottom;
    background-size: 1ex 4.5px;
    background-repeat: space no-repeat;
    content: "";
    flex-grow: 1;
    height: 1em;
    order: 2;
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/pdf/how-to/table-of-contents/dot-line.webp" alt="Remove dots" class="img-responsive add-shadow">
    </div>
</div>