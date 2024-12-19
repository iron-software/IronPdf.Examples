# Transform PDF Pages in .NET

***Based on <https://ironpdf.com/how-to/transform-pdf-pages/>***


Modifying a PDF page often entails executing various operations to alter how the content on that page appears or is arranged. Such transformations might include scaling (changing the size of the page) and translating (shifting the content to a new location).

### Start Using IronPDF

-----

## PDF Page Transformations

Two key transformation features allow you to move and scale the content on a PDF page. These adjustments alter only the visible aspect of the content, without modifying the actual dimensions of the page itself. Let's use the `Transform` method on a [sample PDF document](https://ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/basic.pdf).

```cs
using IronPdf;

// Load a basic PDF document
PdfDocument pdf = PdfDocument.FromFile("basic.pdf");

// Apply transformation: move (50, 50) and scale by 80%
pdf.Pages[0].Transform(50, 50, 0.8, 0.8);

// Save the transformed PDF
pdf.SaveAs("transformPage.pdf");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
      <img src="https://ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/transform.webp" alt="Transform PDF pages" class="img-responsive add-shadow">
    </div>
</div>