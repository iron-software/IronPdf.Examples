# How to Generate PDF/UA Compliant Documents in C&#35;

***Based on <https://ironpdf.com/how-to/pdfua/>***


IronPDF facilitates the generation of PDF documents adhering to the PDF/UA standard, enhancing accessibility for users with disabilities. The PDF/UA standard incorporates guidelines that support assistive technologies such as screen readers, ensuring your documents comply with the accessibility mandates of Section 508 of the Rehabilitation Act.

Additionally, the PDF/UA standard enhances the user experience by offering features like text reflow on smaller devices, advanced navigation aids, customizable text styles, improved search capabilities, and better text selection and copying functionality.

<h3>Getting Started with IronPDF</h3>

---

## Example of Exporting a PDF/UA Document

To create a PDF document that complies with the PDF/UA standard, utilize the `SaveAsPdfUA` method. First, load your PDF document, then apply this method to produce a PDF/UA compliant version. Use the **naturalLanguages** parameter to define the primary language of the document. Below is an example of how you might convert an existing PDF using this method.

Input file: "**[wikipedia.pdf](https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf)**"

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Example Code

```cs
using IronPdf;

// Initialize the PDF document from a file
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Convert to a PDF/UA compliant version
pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
```

### Final Output

The resulting file is compliant with PDF/UA standards:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia-pdfua-passed.webp" alt="PDF/UA compliant" class="img-responsive add-shadow">
    </div>
</div>

PDF Output:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/pdf-ua-wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

Please note that converting HTML strings, files, or URLs directly into a PDF/UA compliant PDF is not supported at this time.