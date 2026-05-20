# How to Replace Text in a PDF

***Based on <https://ironpdf.com/how-to/find-replace-text/>***


Replacing text in PDF documents is an essential feature for efficiently editing documents by correcting errors, updating details, or tailoring content for varied uses. This capability significantly reduces time and effort for those managing documents needing regular updates or personalization.

IronPDF offers a robust solution for text replacement within PDFs, proving to be a crucial tool for developers and professionals looking to automate or tailor PDF content.

## Quickstart: Replace Text in PDF with IronPDF

Easily replace text within your PDF documents using IronPDF. This straightforward approach requires only a few lines of code to swiftly alter or personalize your documents. Below, we provide an example showing how to replace text across a PDF’s entire document. Just load your PDF, enter the text you wish to replace, and save the revised document. IronPDF enables effortless text modification in C# and enhances efficiency within .NET frameworks.

```cs
:title=Effortless PDF Text Replacement
IronPdf.PdfDocument.FromFile("example.pdf")
    .ReplaceTextOnAllPages("old text", "new text")
    .SaveAs("updated.pdf");
```

## Replace Text Example

The text replacement feature can be utilized on any `PdfDocument`, whether it is a new or imported document. Employ the `ReplaceTextOnAllPages` method by specifying the text you want to change. Should the method not find the intended text, an exception will be thrown, notifying that the text replacement has failed.

### Code

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

string oldText = ".NET6";
string newText = ".NET7";

// Execute text replacement across all pages
pdf.ReplaceTextOnAllPages(oldText, newText);

pdf.SaveAs("replaceText.pdf");
```

### Replace Text with Newline

This feature also supports replacing text with new strings that include newline characters (`\n`), enhancing format and readability.

## Replace Text on Specific Pages

IronPDF also supports text replacement on designated pages, enhancing precision when editing specific parts of a document. Utilize `ReplaceTextOnPage` for single pages or `ReplaceTextOnPages` for multiple specified pages. Remember that page indexes are zero-based.

### Replace Text on a Single Page

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

string oldText = ".NET6";
string newText = ".NET7";

// Focus text replacement on page one
pdf.ReplaceTextOnPage(0, oldText, newText);

pdf.SaveAs("replaceTextOnSinglePage.pdf");
```

### Replace Text on Multiple Pages

```csharp
using IronPdf;

string html = @"<p> .NET6 </p>
<p> This is 1st Page </p>
<div style = 'page-break-after: always;'></div>
<p> This is 2nd Page</p>
<div style = 'page-break-after: always;'></div>
<p> .NET6 </p>
<p> This is 3rd Page</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

string oldText = ".NET6";
string newText = ".NET7";

int[] pages = { 0, 2 };

// Apply text replacement on pages 1 and 3
pdf.ReplaceTextOnPages(pages, oldText, newText);

pdf.SaveAs("replaceTextOnMultiplePages.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/find-replace-text/replaceTextOnMultiplePages.pdf" width="100%" height="400px">
</iframe>

## Use Custom Font

With IronPDF, adding and utilizing custom fonts during text replacement is feasible. Below is an example using the [Pixelify Sans Font](https://fonts.google.com/specimen/Pixelify+Sans).

```csharp
using IronPdf;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Use custom font .NET6</h1>");

string oldText = ".NET6";
string newText = ".NET7";

// Load custom font
byte[] fontByte = File.ReadAllBytes(@".\PixelifySans-VariableFont_wght.ttf");
var pdfFont = pdf.Fonts.Add(fontByte);

// Replace text using the custom font
pdf.ReplaceTextOnPage(0, oldText, newText, pdfFont, 24);

pdf.SaveAs("replaceCustomText.pdf");
```

### Result

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/find-replace-text/custom-font.webp" alt="Use custom font" class="img-responsive add-shadow">
    </div>
</div>