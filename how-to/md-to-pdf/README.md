# Markdown to PDF Conversion

***Based on <https://ironpdf.com/how-to/md-to-pdf/>***


Markdown is a straightforward markup language often used for creating readable and easily editable text files, typically with the `.md` or `.markdown` extensions. IronPDF supports converting both Markdown files and Markdown strings directly into PDF documents.

## Example: Converting Markdown String to PDF

To convert a Markdown-formatted string into a PDF file, you can use the `RenderMarkdownStringAsPdf` method from IronPDF. This method supports various `RenderingOptions`, such as adding [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [text overlays and image stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), [page numbering](https://ironpdf.com/how-to/headers-and-footers/), and customization of page dimensions and orientation. After the document is created, it can be further customized by [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating pages, and adding [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/).

```cs
using IronPdf;
namespace ironpdf.MdToPdf
{
    public class Section1
    {
        public void Run()
        {
            // Create PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Define Markdown content
            string markdownContent = "This is some **bold** and *italic* text.";
            
            // Convert Markdown to PDF
            PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(markdownContent);
            
            // Save the PDF file
            pdf.SaveAs("pdfFromMarkdownString.pdf");
        }
    }
}
```

## Example: Converting Markdown File to PDF

To turn a Markdown file into a PDF document, use the `RenderMarkdownFileAsPdf` method. For demonstration, you can download a [sample Markdown file here](https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/sample.md) and see how it converts to PDF.

### Code Sample

```cs
using IronPdf;
namespace ironpdf.MdToPdf
{
    public class Section2
    {
        public void Run()
        {
            // Create PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert specific Markdown file to PDF
            PdfDocument pdf = renderer.RenderMarkdownFileAsPdf("sample.md");
            
            // Output the PDF file
            pdf.SaveAs("pdfFromMarkdownFile.pdf");
        }
    }
}
```

### Viewing the Resulting PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/md-to-pdf/pdfFromMarkdownFile.pdf" width="100%" height="500px">
</iframe>

The PDF conversion showcases that elements like Code, Code Blocks, Blockquotes, Tables, and Checkboxes currently have limitations in rendering which are integral to this method.