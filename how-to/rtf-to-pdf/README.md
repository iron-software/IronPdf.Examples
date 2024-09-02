# Converting Rich Text Format (RTF) to PDF Using IronPDF

Rich Text Format (RTF) is a standard that Microsoft introduced for creating and sharing document files containing rich text like different fonts, styling, and images. While feature-packed, RTF files don't offer the same capabilities as other formats such as DOCX or PDF.

Using IronPDF, you can convert RTF content from either strings or files directly into PDFs. This conversion is beneficial as PDFs are widely accessible, can be compressed, and are print-ready, ensuring document consistency, security, and print readiness across various platforms.

## Example: Converting RTF Content from a String to PDF

To convert RTF content from a string to a PDF document, you will use the `RenderRtfStringAsPdf` method. This method is compatible with various **RenderingOptions** which include implementing [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [text and image stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), [page numbering](https://ironpdf.com/how-to/headers-and-footers/), as well as customizing page sizes and orientations. Further manipulations such as [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating pages, adding [annotations](https://ironpdf.com/how-to/annotations/), and [bookmarks](https://ironpdf.com/how-to/bookmarks/) can also be applied after the PDF is generated.

```cs
using IronPdf;

// Create a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define the RTF string
string rtf = @"{\rtf1\ansi\deff0{\fonttbl{\f0 Arial;}}{\colortbl;\red0\green0\blue0;}\cf0This is some \b bold \b0 and \i italic \i0 text.}";

// Convert RTF to PDF
PdfDocument pdf = renderer.RenderRtfStringAsPdf(rtf);

// Store the PDF
pdf.SaveAs("RenderedPdfFromRtfString.pdf");
```

## Example: Converting an RTF File to a PDF

To convert a specific RTF file into a PDF, utilize the `RenderRtfFileAsPdf` method. Access a sample RTF file by visiting this [link](https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/sample.rtf), which is a practical starting point for conversion.

### Preview of RTF File in Microsoft Word

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/rtf-on-microsoft-word.webp" alt="Open RTF file on Microsoft Word" class="img-responsive add-shadow">
    </div>
</div>

### Code Example

```cs
using IronPdf;

// Create a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert RTF file to PDF
PdfDocument pdf = renderer.RenderRtfFileAsPdf("sample.rtf");

// Store the PDF
pdf.SaveAs("ConvertedPdfFromRtfFile.pdf");
```

### Display the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/ConvertedPdfFromRtfFile.pdf" width="100%" height="400px">
</iframe>

By following these guidelines, you can efficiently convert RTF documents into PDFs, leveraging IronPDF's rich features for customized and secure PDF productions.