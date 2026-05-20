# Creating a Table of Contents

***Based on <https://ironpdf.com/how-to/table-of-contents/>***


A table of contents (TOC) serves as a navigational guide, outlining the major sections or chapters of a PDF document with corresponding page numbers. Positioned usually at the beginning of the document, it enables readers to quickly locate and jump to specific sections, enhancing accessibility to vital information.

IronPDF offers a straightforward method for generating a table of contents which integrates hyperlinks targeting 'h1' through 'h6' headings. This functionality is designed to work seamlessly with existing HTML styles without interference.

```cs
:title=Swift PDF Table of Contents Generation
new ChromePdfRenderer { RenderingOptions = { CreateOutlineMaps = true, OutlineMapsFormat = TableOfContentsTypes.WithPageNumbers, FirstPageNumber = 1 } }
    .RenderHtmlFileAsPdf("myDocument.html")
    .SaveAs("withToc.pdf");
```

## Implementing a Table of Contents

IronPDF enables the insertion of a table of contents into your PDF via the `TableOfContents` property. You can configure this property using one of three `TableOfContentsTypes` as outlined below:
- None: No table of contents is generated.
- Basic: Produces a table of contents devoid of page numbers.
- WithPageNumbers: Generates a table of contents that includes page numbers.

The table of contents is constructed using JavaScript, which requires JavaScript support to be enabled on the rendering engine. For a practical demonstration, download the example HTML file:
- [Download the sample HTML file](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/tableOfContent.html)

### Coding Example

```csharp
using IronPdf;

// Initialize ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options
renderer.RenderingOptions = new ChromePdfRenderOptions
{
    // Activate TOC feature
    TableOfContents = TableOfContentsTypes.WithPageNumbers,
};

PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableOfContent.html");

pdf.SaveAs("tableOfContents.pdf");
```

### PDF Display

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/tableOfContents.pdf#view=75%&page=2" width="100%" height="500px"></iframe>

Hyperlinks are automatically created in the table of contents for each header tag from 'h1' to 'h6'.

Note that using the `Merge` function can disrupt the hyperlinks in the table of contents.

---

## Positioning the Table of Contents in Your PDF

1. Ensure your HTML document includes necessary header tags from h1 to h6.
2. Optionally, add a placeholder `div` for the table of contents' position. If omitted, IronPDF will place the TOC at the beginning.

```html
<div id="ironpdf-toc"></div>
```

3. Configure the render options to include the table of contents, with or without page numbers.

---

## Customizing Table of Contents Style

Styling options for the table of contents are comprehensive, affecting different elements through CSS:

- For general TOC styling, download the provided CSS file:
  [Download the custom CSS file](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/custom.css)

- Avoid altering the `page-break-before` and `page-break-after` to ensure accurate page numbering.

```csharp
using IronPdf;
using System.IO;

// Establish Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Apply rendering settings
renderer.RenderingOptions = new ChromePdfRenderOptions
{
    // Activate TOC feature
    TableOfContents = TableOfContentsTypes.WithPageNumbers,
    CustomCssUrl = "./custom.css"
};

// Load HTML from file
string html = File.ReadAllText("tableOfContent.html");
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

pdf.SaveAs("tableOfContents.pdf");
```

### Customizing Header Styles

Adjust the appearance of individual headers using CSS:

```css
#ironpdf-toc ul li.h1 {
   font-style: italic;
   font-weight: bold;
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/style-headers.webp" alt="Style headers" class="img-responsive add-shadow">
    </div>
</div>

### Font Settings

Modify font settings using CSS for title and page number fields:

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

- [Download the Lemon font](https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/Lemon-Regular.ttf)

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/font-family.webp" alt="Set custom font family" class="img-responsive add-shadow">
    </div>
</div>

### Adjusting Indentation

Control indentation levels via CSS:

```css
:root {
    --indent-length: 25px;
}
```

### Removing Dotted Lines

Eliminate the dotted line styling between headers and page numbers by modifying the `::after` CSS selector:

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

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/table-of-contents/dot-line.webp" alt="Remove dots" class="img-responsive add-shadow">
    </div>
</div>

Explore more capabilities by visiting [Convert PDFs tutorial page](https://ironpdf.com/tutorials/convert-pdf/).