# Exporting PDF/UA Format Documents Using C# and IronPDF

***Based on <https://ironpdf.com/how-to/pdfua/>***


IronPDF provides a simple way to create PDF documents that adhere to the PDF/UA standard, making them accessible and usable by individuals with disabilities. By embracing PDF/UA, your documents become compliant with accessibility guidelines such as those outlined in Section 508 of the Rehabilitation Act, and they become friendlier for use with assistive technologies such as screen readers.

PDF/UA compliant documents have additional perks, including text reflow for better viewing on smaller devices, customizable text options, advanced navigation features, optimized search engine detection, and improved text extraction capabilities.

## Getting Started: Crafting PDF/UA Compliant Documents

With IronPDF, crafting documents that comply with the PDF/UA standard is straightforward. Start with an existing PDF file and use IronPDF to convert it into the PDF/UA format, enhancing accessibility swiftly. The following section provides a quick guide on how to accomplish this using the IronPDF library.

```csharp
// Example: Creating a PDF/UA document with IronPDF
var document = IronPdf.PdfDocument.FromFile("input.pdf");
document.SaveAsPdfUA("accessible-output.pdf");
```

## How to Convert PDFs into PDF/UA Compliant Files

To convert a PDF into a PDF/UA compliant file, utilize the `SaveAsPdfUA` method from IronPDF. Just load your PDF file and apply this method to produce a PDF/UA version. You can specify the primary language of the document using the `naturalLanguages` argument. Below is an example PDF and the code necessary to convert it to a PDF/UA compliant document. IronPDF defaults to creating output files compliant with PDF/UA-1.

Input File: [Open wikipedia.pdf](https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf)

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Conversion Code

```csharp
using IronPdf;

// Load the PDF
PdfDocument pdfDoc = PdfDocument.FromFile("wikipedia.pdf");

// Convert and save as a PDF/UA compliant file
pdfDoc.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
```

### Visual Confirmation of Compliance

The PDF has been successfully converted to meet PDF/UA standards:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia-pdfua-passed.webp" alt="PDF/UA compliant" class="img-responsive add-shadow">
    </div>
</div>

Modified PDF:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/pdf-ua-wikipedia.pdf#view=fit" width="100%" height="500px">
</iframe>

### Rendering HTML to PDF/UA Standard

IronPDF extends its capabilities to convert HTML directly into PDF/UA standard documents. Below is a concise example showcasing how to use IronPDF's `RenderHtmlAsPdfUA` method for this purpose.

#### Example Code

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Prepare the HTML content
var htmlContent = @"
    <!DOCTYPE html>
    <html>
    <head>
        <title>Accessible Document</title>
    </head>
    <body>
        <h1>Main Title</h1>
        <h2>Sub Title</h2>
        <p>This is a sample text paragraph.</p>
    </body>
    </html>";

// Render and save the PDF/UA compliant document
var createdPdf = renderer.RenderHtmlAsPdfUA(htmlContent);

createdPdf.MetaData.Title = "Version 2025.1";

createdPdf.SaveAs("rendered-html-as-pdfua.pdf");
```

### Final Output

The resultant file adheres to the PDF/UA guidelines:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdfua/wikipedia-pdfua-passed.webp" alt="PDF/UA compliant" class="img-responsive add-shadow">
    </div>
</div>