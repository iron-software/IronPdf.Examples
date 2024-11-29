# Generating PDF/UA Compliant Documents in C#

***Based on <https://ironpdf.com/how-to/pdfua/>***


IronPDF supports the creation of PDF documents adhering to the PDF/UA standard, which ensures that the content is accessible to individuals with disabilities. PDF/UA compliance involves adhering to established guidelines that enhance the compatibility with assistive technologies such as screen readers. Adhering to these standards will ensure that your PDFs are in line with Section 508 of the Rehabilitation Act requirements.

In addition to its accessibility features, PDF/UA also offers various advantages including the ability to reflow text for better viewing on smaller screens, improved document navigation, customizable text attributes, better functionality for search engines, and more efficient text selection and copying capabilities.

## Example: Creating a PDF/UA-Compliant Document

To create a PDF document that meets the PDF/UA standard, use the `SaveAsPdfUA` method. First, load your PDF file into the software, then apply this method to generate a PDF/UA compliant version. You should specify the **naturalLanguages** parameter to indicate the document's primary language. The code below demonstrates how to convert an existing document, for example, the one named "wikipedia.pdf," into a PDF/UA compliant file.

Input file: "**[wikipedia.pdf](https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf)**"

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Code Example

```cs
using IronPdf;
namespace ironpdf.Pdfua
{
    public class Section1
    {
        public void Run()
        {
            // Load the PDF file
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Convert and save the PDF as PDF/UA compliant
            pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
        }
    }
}
```

### Resulting Output

The resulting document complies with PDF/UA standards:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia-pdfua-passed.webp" alt="PDF/UA compliant" class="img-responsive add-shadow">
    </div>
</div>

Output PDF:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/pdf-ua-wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

Note: The current version of IronPDF does not support exporting a PDF/UA file from HTML strings, files, or URLs that have been newly rendered.