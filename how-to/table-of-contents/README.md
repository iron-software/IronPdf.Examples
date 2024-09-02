# How to Create a Table of Contents in PDFs

A table of contents (TOC) serves as a detailed guide, simplifying navigation across different sections of a PDF by outlining the primary headings and their corresponding starting page numbers. Typically positioned at the beginning of a document, a TOC enables users to quickly locate and access various parts of the PDF, enhancing the usability and accessibility of the document.

IronPDF supports generating a table of contents with clickable links for the headings 'h1' through 'h6'. This feature integrates seamlessly with your existing HTML styles, ensuring a cohesive look and feel in the final PDF.

## Implementing a Table of Contents

The **TableOfContents** option in IronPDF allows you to integrate a table of contents into your PDFs. This feature supports three distinct **TableOfContentsTypes**, which are outlined below:
- None: Omits the table of contents.
- Basic: Generates a TOC without any page numbers.
- WithPageNumbers: Creates a TOC that includes page numbers.

For a practical demonstration, access the following sample HTML file:
- [Download the sample HTML file](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/tableOfContent.html)

### Example Code

```cs
using IronPdf;
using System.IO;

// Create a new PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options with TOC enabled
renderer.RenderingOptions = new ChromePdfRenderOptions
{
    TableOfContents = TableOfContentsTypes.WithPageNumbers, // Enable TOC with page numbers
};

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableOfContent.html");

// Save the generated PDF
pdf.SaveAs("tableOfContents.pdf");
```

### Displaying the PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/tableOfContents.pdf#view=75%&page=2" width="100%" height="500px">
</iframe>

This setup creates a TOC linking to each heading tag from 'h1' to 'h6'.

## Positioning the TOC in the Document

1. Verify that your HTML contains appropriate heading tags (h1 to h6).
2. Alternatively, define a `div` where the TOC should be inserted. If this div is absent, IronPDF automatically places the TOC at the beginning of the document.
```html
<div id="ironpdf-toc"></div>
```
3. Choose to include or exclude page numbers in the TOC through the rendering options.

## Customizing the TOC Appearance

The TOC's appearance can be tailored using CSS by targeting specific CSS selectors associated with the TOC's style.

Furthermore, you can apply a custom CSS file for the TOC using the **CustomCssUrl** property. Start by downloading the CSS template provided:
- [Download the custom CSS file](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/custom.css)

It's advised not to alter the `page-break-before` and `page-break-after` CSS properties to maintain accurate page numbering.

```cs
using IronPdf;
using System.IO;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options including custom CSS
renderer.RenderingOptions = new ChromePdfRenderOptions
{
    TableOfContents = TableOfContentsTypes.WithPageNumbers,
    CustomCssUrl = "./custom.css"
};

// Load and convert HTML to PDF
string html = File.ReadAllText("tableOfContent.html");
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the PDF
pdf.SaveAs("tableOfContents.pdf");
```

### Custom Fonts

You can change the font for the TOC by targeting specific CSS selectors and using the `@font-face` rule for custom fonts like '[Lemon](https://fonts.google.com/specimen/Lemon)', created by Eduardo Tunni.

- [Download the Lemon font](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/Lemon-Regular.ttf)

```css
#ironpdf-toc li .title {
    order: 1;
    font-family: cursive;
}

@font-face {
    font-family: 'lemon';
    src: url('Lemon-Regular.ttf');
}

#ironpdf-toc li .page {
    order: 3;
    font-family: 'lemon', sans-serif;
}
```

### Adjusting Indentation and Styling

Control the indentation for each header level in the TOC using the ':root' selector.

```css
:root {
    --indent-length: 25px;
}
```

### Eliminating Dot Lines

Modify CSS to remove the dotted lines by changing the styling parameters.

```css
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

With these steps, you can effectively enhance the presentation and navigability of your PDF documents using IronPDF's comprehensive features.