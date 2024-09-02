# How to Redact Text and Regions

<div class="alert alert-info iron-variant-1" role="alert">
	Tired of overspending on annual subscriptions for PDF security? Look into <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for a comprehensive suite of services including digital signing, redaction, encryption, and protection with a one-time payment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Explore here</a>
</div>

Text redaction is essential for deleting or concealing sensitive or private information from documents. The process usually involves blanketing the text with a black overlay or completely erasing the text to ensure it remains inaccessible and secured.

Similarly, redacting specific regions in a document requires a bit more precision as it necessitates defining the exact coordinates and dimensions of the area to be obscured.

## Redact Text Example

Redacting text is streamlined with IronPdf. The `RedactTextOnAllPages` method allows for removal of specific phrases from an entire document. Consider this [sample PDF](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf):

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

// Removes the 'are' phrase from every page
pdf.RedactTextOnAllPages("are");

pdf.SaveAs("redacted.pdf");
```

### Output PDF

Here is a PDF showing the results of the text redaction across all its pages.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redacted.pdf" width="100%" height="400px">
</iframe>

To redact text from single or multiple pages, use the `RedactTextOnPage` and `RedactTextOnPages` methods.

Here are the function parameters for redacting text and their specific roles:
- **ReplaceText**: The string of text to be redacted.
- **CaseSensitive**: Determines case sensitivity of the search. If set to true, it exact matches letter case. The default is false.
- **OnlyMatchWholeWords**: Set to true to match complete words only. Default is true.
- **DrawRectangles**: Enables drawing black rectangles over redacted areas. Default is true.
- **ReplacementText**: The text that appears in place of redaction. By default, it's "*".

<hr>

## Redact Regions Example

Effectively redact areas within the document by using the `RedactRegionsOnAllPages` method with a RectangleF object. Here's the same [PDF sample](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf) as from our earlier example:

```cs
using IronPdf;
using IronSoftware.Drawing;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

RectangleF rectangle = new RectangleF(5, 700, 50, 50);

// Targets and redacts a region at coordinates (5,700) of 50x50 pixels
pdf.RedactRegionsOnAllPages(rectangle);

pdf.SaveAs("redactedRegion.pdf");
```

### Output PDF

View the PDF after redacting a specific region at the coordinates (5,700) with a span of 50x50 pixels.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redactedRegion.pdf" width="100%" height="400px">
</iframe>

For redacting regions from individual pages or multiple selected pages, you can employ `RedactRegionOnPage` and `RedactRegionOnPages` methods respectively.