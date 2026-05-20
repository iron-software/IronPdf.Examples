# Transform PDF Pages in .NET

***Based on <https://ironpdf.com/how-to/transform-pdf-pages/>***


Transforming a PDF page generally involves applying various operations that alter the visual presentation or arrangement of content on the page. Common transformations include scaling, where you resize the page, and translating, where you shift the content to a new position.

## Quickstart: Transform PDF Pages Effortlessly

Discover how to effortlessly transform PDF pages using the IronPDF library in .NET. With a few simple lines of code, you can adjust scale and shift content, maintaining the original dimensions of the page. This guide shows you how to apply these modifications to enhance your PDF documents fluidly.

```cs:title=Transform PDF pages with both translation and scaling in one step!
IronPdf.PdfDocument.FromFile("input.pdf")
  .Pages[0].Transform(50, 50, 0.8, 0.8)
  .SaveAs("output-transformed.pdf");
```

## Transform PDF Pages

The transformation features allow for moving and resizing page content. These modifications affect only the display of the content and do NOT alter the physical dimensions of the page. Explore how to use the `Transform` method on this [basic PDF document example](https://ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/basic.pdf).

```csharp
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("basic.pdf");

// Apply scaling and translation on page 0
pdf.Pages[0].Transform(50, 50, 0.8, 0.8);

// Save the transformed page to a new PDF
pdf.SaveAs("transformedPage.pdf");
```

- **Scalable Transformation**: This code section scales the PDF content down to 80% of its original size by using scale factors of 0.8 for both width and height.
- **Translation Transformation**: Moves the content of the PDF page 50 units to the right and 50 units down, effectively repositioning it within the page.
- **Saving the Transformed PDF**: Once the transformations have been applied, the document is saved under a new file name.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/transform.webp" alt="Transform PDF pages" class="img-responsive add-shadow">
    </div>
</div>