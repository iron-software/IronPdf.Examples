# Convert RTF to PDF Using IronPDF

***Based on <https://ironpdf.com/how-to/rtf-to-pdf/>***


RTF, or Rich Text Format, is a file type created by Microsoft that handles basic text formatting and can include images. While functional, RTF is not as complex as other formats like DOCX or PDF.

Using IronPDF, you can convert RTF content from files or strings directly to PDF. This conversion process provides advantages such as better accessibility, reduced size, and a format optimized for printing. The transformation ensures uniform presentation, heightened security, and print readiness on any platform.

## Getting Started with IronPDF
-----

## Example: Converting RTF String to PDF

To convert an RTF string to a PDF, employ the `RenderRtfStringAsPdf` method. The method supports a variety of **RenderingOptions**. These include adding [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [text and image stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), [custom page numbering](https://ironpdf.com/how-to/headers-and-footers/), as well as setting custom orientations and sizes for pages. Once the PDF is created, you can modify the PDF further by [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating pages, and adding [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/).

```cs
using IronPdf;

// Instantiating the Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Defining the RTF string
string rtf = @"{\rtf1\ansi\deff0{\fonttbl{\f0 Arial;}}{\colortbl;\red0\green0\blue0;}\cf0This is some \b bold \b0 and \i italic \i0 text.}";

// Convert the RTF string to PDF
PdfDocument pdf = renderer.RenderRtfStringAsPdf(rtf);

// Save the resulting PDF
pdf.SaveAs("pdfFromRtfString.pdf");
```

## Example: Converting RTF File to PDF

To convert an RTF file into a PDF document, utilize the `RenderRtfFileAsPdf` method. Download the example RTF file from the following [link](https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/sample.rtf) to try it yourself.

### Preview of RTF File in Microsoft Word

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/rtf-on-microsoft-word.webp" alt="Open RTF file on Microsoft Word" class="img-responsive add-shadow">
    </div>
</div>

### Sample Code

```cs
using IronPdf;

// Initialize Renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert the RTF file to PDF
PdfDocument pdf = renderer.RenderRtfFileAsPdf("sample.rtf");

// Save the generated PDF
pdf.SaveAs("pdfFromRtfFile.pdf");
```

### View the Generated PDF 
<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/pdfFromRtfFile.pdf" width="100%" height="400px">
</iframe>