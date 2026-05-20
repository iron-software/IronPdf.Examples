# Converting RTF to PDF with IronPDF

***Based on <https://ironpdf.com/how-to/rtf-to-pdf/>***


RTF, which stands for Rich Text Format, is a document formatting system created by Microsoft. Unlike formats such as DOCX or PDF, RTF's capabilities in styling and media embedding are somewhat limited, yet it remains widely used for basic document creation including text and simple visuals.

IronPDF provides an efficient solution for converting RTF files and strings into PDF documents. This conversion process offers numerous advantages, including consistent visual appearance on various platforms, better security features, compact file size, and excellent print quality.

## Quick Guide: Converting RTF to PDF with IronPDF

Start converting your RTF documents into professional-quality PDFs using IronPDF. This robust tool allows you to effortlessly convert Rich Text Format files into secure, easily distributable PDFs, perfect for both sharing and printing. Integrating IronPDF into your .NET C# projects for RTF to PDF conversion is straightforward and efficient.

```cs
:title=One-step RTF to PDF conversion!
new IronPdf.ChromePdfRenderer()
     .RenderRtfFileAsPdf("input.rtf")
     .SaveAs("result.pdf");
```

## Example: Converting an RTF String to a PDF Document

Leverage the `RenderRtfStringAsPdf` function to turn an RTF string directly into a PDF file. This method also supports a wide range of **RenderingOptions**, including setting [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [image and text stamping](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), [page numbering](https://ironpdf.com/how-to/headers-and-footers/), and adjusting the page size and orientation. Furthermore, after your PDF is generated, you can manage the PDF's structure by [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating, as well as adding [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/) to enhance its utility and navigability.

```csharp
using IronPdf;

// Create a new renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Define the RTF string
string rtfString = @"{\rtf1\ansi\deff0{\fonttbl{\f0 Arial;}}{\colortbl;\red0\green0\blue0;}\cf0Here is some \b bold \b0 and \i italic \i0 text.}";

// Convert RTF string to PDF
PdfDocument pdfDocument = renderer.RenderRtfStringAsPdf(rtfString);

// Save the generated PDF
pdfDocument.SaveAs("newPdfFromRtfString.pdf");
```

## Converting an RTF File to PDF

To convert an RTF file to a PDF, simply utilize the `RenderRtfFileAsPdf` function. If needed, a sample RTF file can be accessed through this [link](https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/sample.rtf). Below, we provide an example demonstrating how to convert this sample RTF file into a PDF.

### Preview of RTF File in Microsoft Word

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/rtf-on-microsoft-word.webp" alt="Open RTF file on Microsoft Word" class="img-responsive add-shadow">
    </div>
</div>

### Conversion Code Example

```csharp
using IronPdf;

// Create a new renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert an RTF file to PDF
PdfDocument pdf = renderer.RenderRtfFileAsPdf("sample.rtf");

// Save the new PDF
pdf.SaveAs("pdfConvertedFromRtfFile.pdf");
```

### Viewing the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/rtf-to-pdf/pdfFromRtfFile.pdf" width="100%" height="400px">
</iframe>

Explore more capabilities by checking out our detailed tutorial on [PDF Conversions](https://ironpdf.com/tutorials/convert-pdf/).