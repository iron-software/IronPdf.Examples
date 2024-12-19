# Adding Text and Images to PDFs

***Based on <https://ironpdf.com/how-to/draw-text-and-bitmap/>***


Incorporating text and bitmap images into a PDF can significantly enhance its functionality and aesthetic appeal. Using IronPDF, you can easily insert watermarks, logos, annotations, and other elements into your documents. This not only improves branding but also enhances information presentation through visual data and interactive elements.

### Starting with IronPDF

---

## Example: Adding Text to PDFs

To insert text into an existing PDF while preserving the original content, you can use the `DrawText` method of the `PdfDocument` object. Below is a straightforward example:

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Add text to the PDF
pdf.DrawText("Some text", FontTypes.TimesNewRoman.Name, FontSize: 12, PageIndex: 0, X: 100, Y: 100, Color.Black, Rotation: 0);

pdf.SaveAs("drawText.pdf");
```

### Supported Fonts

IronPDF's `DrawText` supports several standard fonts which can be explored in detail in the [Standard Fonts in IronPDF](https://ironpdf.com/how-to/manage-fonts/#standard-fonts). For special characters and symbols, the ZapfDingbats font is particularly notable. You can find a detailed list of symbols this font supports on [Wikipedia on Zapf Dingbats](https://en.wikipedia.org/wiki/Zapf_Dingbats).

#### Display of Font Samples in PDF

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/draw-text-and-bitmap-fonts.webp" alt="Fonts Sample on PDF" class="img-responsive add-shadow">
    </div>
</div>

## Example: Adding Images to PDF

The `DrawBitmap` method allows you to embed images into PDFs, operating similarly to stamping images onto the documents. It is particularly suited for large bitmap images.

### Handling Image Size Exceptions

If smaller images trigger errors, consider using IronPDF's Image Stamper tool for a smoother experience.

#### Example Image

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/ironSoftware.png" alt="1200 x 627 image" class="img-responsive add-shadow">
    </div>
</div>

### Sample Code

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Load the image
AnyBitmap bitmap = AnyBitmap.FromFile("ironSoftware.png");

// Apply the bitmap to the PDF
pdf.DrawBitmap(bitmap, 0, 50, 250, 500, 300);

pdf.SaveAs("drawImage.pdf");
```

### Viewing the Resulting PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/drawImage.pdf#view=fit" width="100%" height="500px">
</iframe>