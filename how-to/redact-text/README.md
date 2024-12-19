# Text and Region Redaction Overview

***Based on <https://ironpdf.com/how-to/redact-text/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Save on annual costs linked to PDF compliance and security by switching to <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>. This solution offers a collection of SaaS controls like encryption, digital signing, and redaction without recurring fees. Discover more through the <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc documentation and features</a>
</div>

Redacting text or regions from a document involves the concealment of sensitive details. Text redaction typically includes overlaying a black box or deleting text completely, securing the information against unauthorized access. Similarly, redaction of a document region demands defining specific dimensions—like coordinates, width, and height—to effectively obscure parts of the document.

<h2>Introduction to IronPDF</h2>

---

## Example: Redacting Text

Achieving text redaction is straightforward with IronPdf. Utilize the `RedactTextOnAllPages` method to eliminate a designated phrase across the entire document. Take a look at this [PDF sample document](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf).

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

// Applying 'Alaric' text redaction across every page
pdf.RedactTextOnAllPages("Alaric");

pdf.SaveAs("redacted.pdf");
```

### Visualizing the Output PDF

Review the outcome of the text redaction applied to the phrase 'Alaric' on all pages.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redacted.pdf" width="100%" height="400px">
</iframe>

For redacting specific text from single or multiple pages, use the `RedactTextOnPage` and `RedactTextOnPages` methods, respectively.

Understanding the parameters for text redaction:
- **ReplaceText**: Defines the text string targeted for redaction.
- **CaseSensitive**: A Boolean setting indicating if the search should differentiate case; set to false by default.
- **OnlyMatchWholeWords**: Boolean that dictates if only complete words should be matched (default is true).
- **DrawRectangles**: Determines if black rectangles are drawn around the redacted areas (default is true).
- **ReplacementText**: Specifies the text to be displayed post-redaction, defaulted to "*".

<hr>

## Example: Redacting Regions

Efficiently redact specific regions in documents using `RedactRegionsOnAllPages` with a RectangleF object. Use the same [PDF sample](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf) as in the previous example.

```cs
using IronPdf;
using IronSoftware.Drawing;

PdfDocument pdf = PdfDocument.FromFile("novel.pdf");

RectangleF rectangle = new RectangleF(5, 700, 50, 50);

// Implementing region redaction at coordinates(5,700) with width 50 and height 50 pixels
pdf.RedactRegionsOnAllPages(rectangle);

pdf.SaveAs("redactedRegion.pdf");
```

### Displaying the Output PDF

Here's the result from applying region redaction at the specified coordinates (5,700) and dimensions (50x50 pixels).

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redactedRegion.pdf" width="100%" height="400px">
</iframe>

To redact specific areas from a single or multiple pages, leverage `RedactRegionOnPage` and `RedactRegionOnPages` methods accordingly.