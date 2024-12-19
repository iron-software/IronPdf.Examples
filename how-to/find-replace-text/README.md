# Replacing Text in PDF Documents

***Based on <https://ironpdf.com/how-to/find-replace-text/>***


The ability to replace text in PDFs is crucial for efficiently managing document edits, such as correcting errors, updating details, or tailoring templates for various uses. This capability greatly reduces time and effort, especially for documents that need regular updates or customization.

IronPDF offers a robust text replacement feature, making it an essential tool for developers and professionals who manage automated or customized PDF content.

<h3>Getting Started with IronPDF</h3>

--------------------------------------

## Example of Text Replacement

Text replacement can be implemented on any `PdfDocument` instance, whether it's a newly created document or an imported one. Utilize the `ReplaceTextOnAllPages` method, entering both the text to be replaced and the new text. If the specified text to replace is not found, an exception is thrown stating "Error while replacing text: failed to find text '.NET6'."

The following code example illustrates how to replace text in a freshly rendered PDF document that contains the text '.NET6':

### Code

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

string oldText = ".NET6";
string newText = ".NET7";

// Replacing text across all pages
pdf.ReplaceTextOnAllPages(oldText, newText);

pdf.SaveAs("replaceText.pdf");
```

## Specifying Pages for Text Replacement

IronPDF also enables precision in text modification within a document, allowing for text replacement on either a particular page or multiple selected pages. Use `ReplaceTextOnPage` for a single page, or `ReplaceTextOnPages` for multiple specified pages.

Page indexes are zero-based.

### Replacing Text on a Single Page

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

string oldText = ".NET6";
string newText = ".NET7";

// Text replacement on page 1
pdf.ReplaceTextOnPage(0, oldText, newText);

pdf.SaveAs("replaceTextOnSinglePage.pdf");
```

### Replacing Text on Multiple Pages

```cs
using IronPdf;

string html = "<p>.NET6</p><p>This is 1st Page</p><div style='page-break-after: always;'></div><p>This is 2nd Page</p><div style='page-break-after: always;'></div><p>.NET6</p><p>This is 3rd Page</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

string oldText = ".NET6";
string newText = ".NET7";

int[] pages = { 0, 2 };

// Replacing text on pages 1 and 3
pdf.ReplaceTextOnPages(pages, oldText, newText);

pdf.SaveAs("replaceTextOnMultiplePages.pdf");
```

### Display of Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/find-replace-text/replaceTextOnMultiplePages.pdf" width="100%" height="400px">
</iframe>