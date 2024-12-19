# Converting Markdown into PDF

***Based on <https://ironpdf.com/how-to/md-to-pdf/>***


Markdown is a streamlined markup language utilized for formatting text, often seen in readme files and community-driven websites like forums. Easy to read and write, it typically uses the `.md` or `.markdown` extensions for its files. IronPDF supports converting Markdown files and strings directly into PDF documents.

<h3>Starting with IronPDF</h3>

-----

## Example: Convert Markdown String to PDF

To transform a Markdown-formatted string into a PDF file, employ the `RenderMarkdownStringAsPdf` method. This method supports various features from **RenderingOptions**. These include implementing [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [text overlays and image stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), and [page numbering](https://ironpdf.com/how-to/headers-and-footers/). It's also possible to set custom page dimensions and orientations. After creating the PDF, additional modifications such as [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating, and adding [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/) are possible.

```cs
using IronPdf;

// Create a new Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define the Markdown string
string md = "This is some **bold** and *italic* text.";

// Generate PDF from the markdown string
PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(md);

// Store the PDF
pdf.SaveAs("pdfFromMarkdownString.pdf");
```

## Example: Convert Markdown File to PDF

To convert a Markdown file into a PDF, use the `RenderMarkdownFileAsPdf` method. Here is a [sample Markdown file](https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/sample.md) available for conversion. Below is how you can convert this sample file into a PDF.

### Code Example

```cs
using IronPdf;

// Create a Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate PDF from the markdown file
PdfDocument pdf = renderer.RenderMarkdownFileAsPdf("sample.md");

// Store the PDF
pdf.SaveAs("pdfFromMarkdownFile.pdf");
```

### Display the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/pdfFromMarkdownFile.pdf" width="100%" height="500px">
</iframe>

As highlighted by the outcome shown in the PDF document, certain Markdown features like Code, Code Block, Blockquote, Tables, and Checkbox do not convert. This is currently a known limitation of the method.