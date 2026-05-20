# Redacting Text and Areas within Documents

***Based on <https://ironpdf.com/how-to/redact-text/>***


<div class="alert alert-info iron-variant-1" role="alert">
    Is your company overpaying on annual PDF security and compliance subscriptions? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for a cost-effective solution. It offers capabilities like digital signing, redaction, encryption, and protection, consolidated into a single cost-effective license. Learn more at <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc documentation</a>.
</div>

Redaction is a crucial process for removing or obscuring personal or confidential information in documents to protect privacy. This usually involves concealing parts of text with a colored overlay or entirely deleting it from the document. These measures prevent unauthorized access to sensitive data, ensuring the document's security and user privacy.

Similarly, when you need to obscure specific sections of a document, area redaction is used. This technique requires precise dimensions including coordinates, as well as width and height specifications.

*as-heading:2(Quick Guide: Redacting Sensitive Information in PDFs)*

Quickly remove confidential details from your PDF files using the seamless redaction features of IronPDF. A few lines of code will allow you to apply comprehensive redaction across all pages of a PDF document. This brief tutorial shows how to open a PDF, apply redactions, and save your privacy-compliant file using the straightforward IronPDF API.

```cs
:title=Immediate Text Redaction in PDFs
IronPdf.PdfDocument document = IronPdf.PdfDocument.FromFile("document.pdf");
document.RedactTextOnAllPages("confidential");
document.SaveAs("secured_document.pdf");
```

## Example of Text Redaction

With IronPDF, text redaction is straightforward. Employ the `RedactTextOnAllPages` method to erase specific text throughout your document. Let’s apply this to a [sample PDF document](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf).

```csharp
using IronPdf;

PdfDocument document = PdfDocument.FromFile("novel.pdf");

// Remove the phrase 'Alaric' from all pages
document.RedactTextOnAllPages("Alaric");

document.SaveAs("secured.pdf");
```

### Redacted PDF Result

Here is the PDF after the phrase 'Alaric' has been removed from all pages.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redacted.pdf" width="100%" height="400px">
</iframe>

For more targeted redactions, utilize `RedactTextOnPage` or `RedactTextOnPages`, which allow for single or multiple page operations.

These methods have the following parameters:
- **ReplaceText**: The specific text to be removed.
- **CaseSensitive**: Flags whether the search recognizes letter casing. If set to true, matches must be exact. Default is false.
- **OnlyMatchWholeWords**: Limits matches to whole words. Default is true.
- **DrawRectangles**: Decides whether to overlay removed sections with black rectangles. Default is true.
- **ReplacementText**: The text to display where content was removed. The default is "*".

<hr>

## Area Redaction Illustration

Effectively redact particular areas in documents with `RedactRegionsOnAllPages` and a `RectangleF` object. Here’s how you can apply this using the same [example PDF](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf):

```csharp
using IronPdf;
using IronSoftware.Drawing;

PdfDocument document = PdfDocument.FromFile("novel.pdf");

RectangleF redactArea = new RectangleF(5, 700, 50, 50);

// Apply redaction on coordinates(5, 700) with a 50 x 50 pixel area
document.RedactRegionsOnAllPages(redactArea);

document.SaveAs("redactedArea.pdf");
```

### PDF Output

Here’s the outcome from redacting a 50 x 50 pixel region at coordinates (5,700).

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redactedRegion.pdf" width="100%" height="400px">
</iframe>

To redact specific pages, use `RedactRegionOnPage` and `RedactRegionOnPages`.

Discover more capabilities by visiting our tutorial page: [Edit PDFs and More](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/)