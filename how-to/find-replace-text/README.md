# Revising PDF Text Content

Changing text in a PDF is invaluable for quickly updating content, fixing typos, altering information, or tailoring templates for distinct needs. This can drastically reduce the time and effort needed, especially when handling documents that necessitate regular updates or customization.

IronPDF offers a robust feature for editing text in PDF files, making it an essential tool for developers and professionals who require efficient PDF content management.

## Example of Text Replacement

Text replacement can be executed on any `PdfDocument` instance, regardless of whether it is newly created or imported. To replace text, use the `ReplaceTextOnAllPages` method with the old text and the new text specified. If the method does not find the old text, it will throw an exception with the message 'Error while replacing text: failed to find text '.NET6'.'

Below is a practical example of how to substitute text in a newly created PDF document that includes the text '.NET6'.

### Code Implementation

```cs
using IronPdf;

// Instantiate a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Create a PDF from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

// Specify the text to be replaced and the new text
string oldText = ".NET6";
string newText = ".NET7";

// Perform the text replacement on all pages
pdf.ReplaceTextOnAllPages(oldText, newText);

// Save the updated PDF
pdf.SaveAs("replaceText.pdf");
```

## Specific Page Text Replacement

IronPDF also allows text to be altered on specific pages. This is useful for targeted updates. You can employ the `ReplaceTextOnPage` method for a single page or the `ReplaceTextOnPages` method for multiple selected pages.

Page indexes are zero-based.

### Single Page Text Replacement

```cs
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF document from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

// Define the original and new text
string oldText = ".NET6";
string newText = ".NET7";

// Replace text on the first page
pdf.ReplaceTextOnPage(0, oldText, newText);

// Save the PDF with text replaced on specified page
pdf.SaveAs("replaceTextOnSinglePage.pdf");
```

### Multiple Pages Text Replacement

```cs
using IronPdf;

// Define HTML content with multiple pages
string html = @"<p>.NET6</p><p>This is 1st Page</p>
<div style='page-break-after: always;'></div>
<p>This is 2nd Page</p>
<div style='page-break-after: always;'></div>
<p>.NET6</p>
<p>This is 3rd Page</p>";

// Create the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render the HTML to a PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Specify the text to change and its replacement
string oldText = ".NET6";
string newText = ".NET7";

// Define the pages for text replacement
int[] pages = { 0, 2 };

// Replace text on specified pages
pdf.ReplaceTextOnPages(pages, oldText, newText);

// Save the PDF with changes on multiple pages
pdf.SaveAs("replaceTextOnMultiplePages.pdf");
```

### PDF Output Display

<iframe loading="lazy" src="https://www.ironpdf.com/static-assets/pdf/how-to/find-replace-text/replaceTextOnMultiplePages.pdf" width="100%" height="400px">
</iframe>