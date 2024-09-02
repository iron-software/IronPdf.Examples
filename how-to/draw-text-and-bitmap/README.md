# How to Add Text and Images to PDFs

Enhancing a PDF by embedding text and images can considerably elevate its functionality and aesthetic. Using IronPDF, you can effortlessly implement customizations such as watermarks, logos, and annotated text to not only improve the document's visual appeal but also enhance its informational value. Adding these elements can make the document more interactive and provide a professional look.

## Example of Adding Text to PDF

Using the `DrawText` method of the **PdfDocument** class, you can insert text onto any page of an existing PDF while preserving the original contents.

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>sample header</h1>");

// Adding text to the PDF
pdf.DrawText("Insert this text", FontTypes.TimesNewRoman.Name, FontSize: 14, PageIndex: 0, X: 150, Y: 150, Color.Black, Rotation: 0);

pdf.SaveAs("exampleText.pdf");
```

### Supported Fonts

The `DrawText` method allows for a range of fonts including Arial, Courier, Helvetica, TimesNewRoman, and ZapfDingbats. To explore more about these font styles, including their italic, bold, or Oblique formats, refer to the [API documentation](https://ironpdf.com/object-reference/api/IronSoftware.Forms.IFormField.html).

For displaying various symbols, the ZapfDingbats font is particularly useful. You can review a complete list of available symbols on [Wikipedia](https://en.wikipedia.org/wiki/Zapf_Dingbats).

#### Display of Fonts in PDF

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/draw-text-and-bitmap-fonts.webp" alt="Fonts Sample on PDF" class="img-responsive add-shadow">
    </div>
</div>

## Example of Adding Images to PDF

The `DrawBitmap` method in IronPDF makes it straightforward to embed images into a PDF, similar to using a stamping tool on the document.

This method is especially effective with high-resolution images. When using images of lower resolution, the following error might appear: **IronPdf.Exceptions.IronPdfNativeException: 'Error while drawing image: data length (567000) is less than expected (756000)'.** For such situations, the Image Stamper tool is recommended as it handles any size of image proficiently.

#### Example Image

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/ironSoftware.png" alt="1200 x 627 image" class="img-responsive add-shadow">
    </div>
</div>

### Code for Adding Image

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>sample header</h1>");

// Load the image from the file system
AnyBitmap bitmap = AnyBitmap.FromFile("ironSoftware.png");

// Embed the image into the PDF
pdf.DrawBitmap(bitmap, 0, 50, 250, 500, 300);

pdf.SaveAs("exampleImage.pdf");
```

### Viewing the Resulting PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/drawImage.pdf#view=fit" width="100%" height="500px">
</iframe>