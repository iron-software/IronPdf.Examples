# Export PDF/UA Compliant Documents in C#

IronPDF enables the creation of documents adhering to the PDF/UA standard, which makes PDFs accessible for users with disabilities. This standard meets the requirements of Section 508 of the Rehabilitation Act, aiding compatibility with assistive technologies such as screen readers.

PDF/UA also enhances the user experience by offering features like text reflow for smaller screens, better navigation, customizable text styles, improved search capabilities, and efficient text highlighting and extraction.

## Example of Exporting a PDF/UA Document

For converting a PDF into a PDF/UA compliant format, utilize the `SaveAsPdfUA` function. First, load your PDF and then apply this function to convert it. The **naturalLanguages** parameter can be set to define the document's primary language. Below is a practical example where a PDF document is converted to a PDF/UA compliant document.

Input file: **[wikipedia.pdf](https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf)**

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Code Sample

```cs
using IronPdf;

// Opening the PDF file
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Converting the PDF to a PDF/UA compliant format
pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
```

### Conversion Result

The resulting file complies with PDF/UA standards:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia-pdfua-passed.webp" alt="PDF/UA compliant" class="img-responsive add-shadow">
    </div>
</div>

Output PDF:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/pdf-ua-wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

Note: Conversion of PDFs from HTML strings, files, or web URLs into PDF/UA format is not supported by IronPDF at this moment.