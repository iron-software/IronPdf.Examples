# How to Conceal Text and Specific Areas in Documents

***Based on <https://ironpdf.com/how-to/redact-text/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Is your company overspending on annual subscriptions for PDF security and compliance services? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, a one-time purchase solution that includes digital signing, redaction, encryption, and protection functionalities tailored to manage SaaS services. Learn more by visiting the <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc documentation and features</a>.
</div>

Concealing text refers to the process of permanently deleting or obscuring private or sensitive information within a document. This usually involves overlaying the text with a black box or entirely removing the text through specialized tools, ensuring the data remains inaccessible, enhancing privacy and document security.

Similarly, concealing specific areas in a document involves obscuring predetermined regions which requires precise measurements of the coordinates, width, and height of the area needing concealment.

## Example: Concealing Text

Concealing text efficiently is attainable using IronPdf. Implement the `RedactTextAllPages` method to eliminate a particular phrase from all pages in a document. Here is an example using a [PDF sample](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf):

```cs
using IronPdf;
namespace ironpdf.RedactText
{
    public class Section1
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("novel.pdf");
            
            // Conceal the phrase 'Alaric' across all pages
            pdf.RedactTextOnAllPages("Alaric");
            
            pdf.SaveAs("redacted.pdf");
        }
    }
}
```

### Resulting PDF

View the resulting PDF where the phrase 'Alaric' has been concealed on all pages.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redacted.pdf" width="100%" height="400px">
</iframe>

For text concealment on single or multiple pages, use the `RedactTextOnPage` and `RedactTextOnPages` methods respectively.

Here are the parameters for these methods and their purposes:
- **ReplaceText**: The text string targeted for redaction.
- **CaseSensitive**: A boolean indicating if the search should be case-sensitive; `true` means exact matches of capital and lowercase letters. By default, this is set to `false`.
- **OnlyMatchWholeWords**: A boolean specifying that only whole words should be matched, set to `true` by default.
- **DrawRectangles**: A boolean that decides whether to draw black rectangles over the redacted areas, also `true` by default.
- **ReplacementText**: This represents the text that replaces the redacted elements, with the default setting as "*".

<hr>

## Example: Concealing Specific Regions

For specific area concealment within a document, use the `RedactRegionsOnAllPages` method along with a `RectangleF` object. Revisiting the same [PDF sample](https://ironpdf.com/static-assets/pdf/how-to/redact-text/novel.pdf):

```cs
using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.RedactText
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("novel.pdf");
            
            RectangleF rectangle = new RectangleF(5, 700, 50, 50);
            
            // Conceal specified region at coordinates(5,700) measuring 50x50 pixels
            pdf.RedactRegionsOnAllPages(rectangle);
            
            pdf.SaveAs("redactedRegion.pdf");
        }
    }
}
```

### Resulting PDF

The resulting PDF showcases the concealed area at coordinates (5,700) with dimensions of 50x50 pixels.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/redact-text/redactedRegion.pdf" width="100%" height="400px">
</iframe>

To conceal regions on a single or multiple pages, consider using the `RedactRegionOnPage` and `RedactRegionOnPages` methods accordingly.