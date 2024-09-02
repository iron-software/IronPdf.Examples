# Transformation of PDF Pages in .NET

In .NET, transforming a PDF page involves a series of operations aimed at altering how the content of that page is presented. These operations may include scaling, which changes the size of the page, and translation, which modifies the position of the content on the page.

## PDF Page Transformations

The `Transform` method offers two functionalities: moving and resizing the content on a page. It's important to note that these transformations only modify how the content appears on the page; they do not alter the actual dimensions of the physical page itself. Let's look at how to apply transformations to a PDF document using the following example:

```cs
using IronPdf;

// Load the PDF file
PdfDocument pdf = PdfDocument.FromFile("basic.pdf");

// Apply transformations: move (x, y) and scale (width, height)
pdf.Pages[0].Transform(50, 50, 0.8, 0.8);

// Save the transformed PDF
pdf.SaveAs("transformedPage.pdf");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/transform.webp" alt="Transform PDF pages" class="img-responsive add-shadow">
    </div>
</div>

In this implementation, the `Transform` method is used to both translate and scale the first page of a PDF document loaded from a file named "basic.pdf". Following the transformation, the document is saved as "transformedPage.pdf", showcasing the new layout.