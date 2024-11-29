# Generating PDF/A Compliant Documents in C#

***Based on <https://ironpdf.com/how-to/pdfa/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Are high subscription costs for PDF security affecting your budget? Discover <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, offering a single-payment solution for functions like digital signatures, redaction, encryption, and protection. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Check out IronSecureDoc's Documentation</a>
</div>

**IronPDF excels in creating PDF files that adhere to the PDF/A-3b** standard. The PDF/A-3b format is a rigorous subset of the ISO PDF standard designed for archival document storage, ensuring that documents maintain their original appearance over time.

#### Section 508 Compliance

IronPDF commits to enhancing PDF archiving and accessibility, aligning with both Google's efforts and Section 508 Compliance standards for PDFs.

In 2021, our approach evolved to include PDF rendering via the Google Chromium HTML rendering engine, enhancing our capabilities through advancements in [accessibility technology pioneered by Google](https://blog.chromium.org/2020/07/using-chrome-to-generate-more.html).

## Supported PDF/A Variants

IronPDF supports conformance levels A (Accessible) and B (Basic) across the PDF/A-1, PDF/A-2, and PDF/A-3 formats, based on the guidelines detailed in [Adobe's PDF/A documentation](https://www.adobe.com/uk/acrobat/resources/document-files/pdf-types/pdf-a.html).

- **Level A** meets all specified requirements, enhancing accessibility for users with disabilities.
- **Level B** ensures long-term preservation of the document's visual integrity, fulfilling basic compliance requirements.

**PDF/A-1**: Anchored in the original PDF 1.4 standards.

**PDF/A-2**: Introduced in July 2011 as ISO 32001-1, this format includes enhancements and supports advanced features like JPEG2000, suitable for high-quality scanned documents, and enriches XMP metadata customization.

**PDF/A-3**: Builds upon the Level 2 standards, permitting the integration of various document types such as XML, CSV, and text processing files within PDF/A-compliant documents.

## Transforming an Existing PDF to PDF/A

Starting with a PDF created with IronPDF named "`wikipedia.pdf`":

### Original PDF: "wikipedia.pdf"

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia.pdf#view=fit" width="100%" height="500px"></iframe>

### Sample Code

```cs
using IronPdf;
namespace ironpdf.Pdfa
{
    public class Section1
    {
        public void Run()
        {
            // Initialize or open an existing PDF
            var pdfDocument = PdfDocument.FromFile("wikipedia.pdf");
            
            // Convert and save the document as PDF/A
            pdfDocument.SaveAsPdfA("pdf-a3-wikipedia.pdf", PdfAVersions.PdfA3b);
        }
    }
}
```

### Result

The created file conforms to the PDF/A-3b standard:

![Document conformity achieved](https://ironpdf.com/static-assets/pdf/how-to/pdfa/wikipedia-pdfa-passed.webp)

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfa/pdf-a3-wikipedia.pdf#view=fit" width="100%" height="500px"></iframe>

## Converting HTML Designs and URLs

Turning an HTML design called "`design.html`" into a compliant PDF/A document:

### HTML Conversion Example

```cs
using IronPdf;
namespace ironpdf.Pdfa
{
    public class Section2
    {
        public void Run()
        {
            // Create PDF from HTML with advanced Chrome rendering
            var renderer = new ChromePdfRenderer();
            var pdfFromHtml = renderer.RenderHtmlAsPdf("design.html");
            
            // Save the result as a PDF/A file
            pdfFromHtml.SaveAsPdfA("design-accessible.pdf", PdfAVersions.PdfA3b);
        }
    }
}
```

Resulting document meets PDF/A-3B standards:

![Document conforms to standard](https://ironpdf.com/static-assets/pdf/how-to/pdfa/design-pdfa-passed.webp)

### Transforming a Website

Rendering the site "`https://www.microsoft.com`" into a compliant PDF file:

```cs
using IronPdf;
namespace ironpdf.Pdfa
{
    public class Section3
    {
        public void Run()
        {
            // Render a webpage using advanced Chrome capabilities
            var chromeRenderer = new ChromePdfRenderer();
            var webPdf = chromeRenderer.RenderUrlAsPdf("https://www.microsoft.com");
            
            // Convert to PDF/A and save
            webPdf.SaveAsPdfA("website-accessible.pdf", PdfAVersions.PdfA3b);
        }
    }
}
```

The resulting PDF is also compliant with PDF/A-3B standards:

![Website conversion successful](https://ironpdf.com/static-assets/pdf/how-to/pdfa/website-pdfa-passed.webp)