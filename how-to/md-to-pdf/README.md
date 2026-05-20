# How to Convert Markdown to PDF

***Based on <https://ironpdf.com/how-to/md-to-pdf/>***


Markdown is a streamlined markup language designed for text formatting, widely utilized in readme files and online forums. It offers an easy-to-read and easy-to-write syntax, typically associated with `.md` or `.markdown` file extensions. Using IronPDF, you can efficiently transform both Markdown files and text into PDF documents.

## Quickstart: Convert Markdown to PDF in Seconds

Leverage IronPDF's straightforward API to turn Markdown files into elegant PDFs quickly. With a minimal amount of C# code, you can convert Markdown documents into polished PDFs. IronPDF provides effective functions that simplify the integration into your .NET projects, conserving both time and energy. Begin by employing the `RenderMarkdownFileAsPdf` method, which swiftly processes your Markdown file and outputs a superior quality PDF, ready to be utilized and shared.

```cs
:title=Easy Markdown to PDF transformation:
// Initialize a new ChromePdfRenderer instance
new IronPdf.ChromePdfRenderer()
    .RenderMarkdownStringAsPdf("Explore **robust** _Markdown_ conversion!")
    .SaveAs("OutputPdf.pdf");
```

## Convert Markdown String to PDF Example

To convert a Markdown-formatted string directly into a PDF, you can use the `RenderMarkdownStringAsPdf` method. This conversion supports all features in **RenderingOptions**, such as adding [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [text overlays and image stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), and [page numbering](https://ironpdf.com/how-to/headers-and-footers/). The method also accommodates custom page sizes and orientations. After creation, the PDF can be further refined by merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating, and inserting [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/).

```csharp
using IronPdf;

// Create a new ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define Markdown content
string markdownContent = "Experience **bold** and _italic_ styling in Markdown.";

// Convert Markdown to PDF
PdfDocument document = renderer.RenderMarkdownStringAsPdf(markdownContent);

// Save the generated PDF
document.SaveAs("EnhancedMarkdownPDF.pdf");
```

## Convert Markdown File to PDF Example

Apply the `RenderMarkdownFileAsPdf` method to transform a Markdown file into a PDF format. You can retrieve a [sample Markdown file here](https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/sample.md) for testing this functionality. Below is a demonstration of converting this file into a PDF.

### Code Example

```csharp
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert the markdown file to PDF
PdfDocument convertedPdf = renderer.RenderMarkdownFileAsPdf("sample.md");

// Save the transformed PDF
convertedPdf.SaveAs("ConvertedMarkdownPDF.pdf");
```

### Visual Preview of Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/pdfFromMarkdownFile.pdf" width="100%" height="500px">
</iframe>

From the PDF shown above, certain elements such as Code, Code Block, Blockquote, Tables, and Checkboxes are not currently supported, which highlights some limitations of this method.

Interested in exploring more functionalities? View additional information on our tutorial page here: [Learn to Convert PDFs](https://ironpdf.com/tutorials/convert-pdf/).