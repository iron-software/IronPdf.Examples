# md-to-pdf: Transforming Markdown to PDF

Markdown is a simplified markup language favored for creating formatted text using plain text editors. It is typically used for composing readme files and contributing content to community forums. Files often have the extensions `.md` or `.markdown`. IronPDF introduces a powerful feature that allows for the conversion of Markdown content directly into PDF files.

## Example: Converting Markdown Text to PDF

IronPDF provides the method `RenderMarkdownStringAsPdf` for transforming Markdown text into a PDF file. During the conversion, all options in **RenderingOptions**, such as adding [text and HTML headers, footers](https://ironpdf.com/how-to/headers-and-footers/), [text overlays, image stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), and [page numbering](https://ironpdf.com/how-to/headers-and-footers/) remain available. Additionally, this approach supports custom page sizes and orientations. After generating the PDF, it's possible to further manipulate the document by [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating, and inserting [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/).

```cs
using IronPdf;

// Create a new PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Markdown content as a string
string md = "This is some **bold** and *italic* text.";

// Convert the Markdown string to a PDF document
PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(md);

// Save the resulting PDF
pdf.SaveAs("pdfFromMarkdownString.pdf");
```

## Converting a Markdown File to a PDF

To convert an existing Markdown file to a PDF, use the `RenderMarkdownFileAsPdf` method. A sample Markdown file can be accessed via this [link](https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/sample.md). Below, we showcase how to turn this sample Markdown file into a PDF document.

### Code Example

```cs
using IronPdf;

// Initialize a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF from a Markdown file
PdfDocument pdf = renderer.RenderMarkdownFileAsPdf("sample.md");

// Store the produced PDF locally
pdf.SaveAs("pdfFromMarkdownFile.pdf");
```

### Displaying the Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/pdfFromMarkdownFile.pdf" width="100%" height="500px">
</iframe>

As demonstrated, the resulting PDF retains many Markdown features like code snippets, blockquotes, tables, and checkboxes. Do note, however, some features may not translate perfectly due to inherent limitations in the method used for conversion.