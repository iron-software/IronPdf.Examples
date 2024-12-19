# Converting PDFs to Images Using IronPDF

***Based on <https://ironpdf.com/how-to/rasterize-pdf-to-images/>***


Converting a PDF into an image format such as JPEG or PNG means transforming the document’s pages into pixel-based images. This process of rasterization helps in displaying PDF content clearly, creating thumbnails, processing images, and securely sharing documents.

IronPDF simplifies the process of converting PDFs into images. It's beneficial for those looking to integrate PDF rendering into their applications, create image previews, conduct image-based manipulations, or enhance the security of their documents.

<h3>Getting Started with IronPDF</h3>

----

## Converting PDF to Images Example

The method `RasterizeToImageFiles` on the `PdfDocument` enables exporting PDF content as images. This can be performed on any PDF loaded through local files, or those converted from HTML using guides like [HTML to PDF](https://ironpdf.com/how-to/html-file-to-pdf/), [HTML string to PDF](https://ironpdf.com/how-to/html-string-to-pdf/), or [URL to PDF](https://ironpdf.com/how-to/url-to-pdf/).

For the output, specify file extensions such as `.png`, `.jpg`, or `.tif` in the `FileNamePattern` parameter. Within this parameter, the asterisk (`*`) is replaced with the page number.

```cs
using IronPdf;

// Set up renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Convert PDF to image files
pdf.RasterizeToImageFiles("wikipage_*.png");
```

### Output Directory

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-rasterize.png" alt="Output folder showing images" class="img-responsive add-shadow">
    </div>
</div>

To ensure that any form fields are visible in your images, flatten the PDF before conversion or set the `Flatten` parameter to true. Read more about form processing in "[How to Fill and Edit PDF Forms](https://ironpdf.com/how-to/edit-forms/)."

<hr>

## Advanced Techniques for Image Rasterization

Let’s explore some advanced settings for the `RasterizeToImageFiles` method.

### Selecting Image Type

Choose your desired image format from BMP, JPEG, PNG, GIF, TIFF, and SVG. Here are some methods to help you save in various formats:

- `ToBitmap`: Converts the PDF to individual Bitmap pages.
- `ToJpegImages`: Saves each page as a separate JPEG file.
- `ToPngImages`: Outputs pages as PNG files.
- `ToTiffImages`: Produces single-page TIFF files per PDF page.
- `ToMultiPageTiffImage`: Creates a multi-page TIFF file from the PDF.
- `SaveAsSvg`: Saves the PDF as an SVG file.
- `ToSvgString`: Returns a specific page as an SVG string.

```cs
using IronPdf;

// Set up renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Convert PDF to PNG images
pdf.RasterizeToImageFiles("wikipage_*.png", IronPdf.Imaging.ImageType.Png);
```

### Specifying DPI

Enhance the sharpness of output images by specifying a higher DPI:

```cs
using IronPdf;

// Set up renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Convert PDF to images with higher DPI
pdf.RasterizeToImageFiles("wikipage_*.png", DPI: 150);
```

### Choosing PDF Pages

Define specific pages for rasterization:

```cs
using IronPdf;
using System.Linq;

// Set up renderer
ChromePdfRenderer(renderer = new ChromePdfRenderer();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Convert selected pages of PDF to images
pdf.RasterizeToImageFiles("wikipage_*.png", Enumerable.Range(1, 3));
```

### Setting Image Dimensions

Control the dimensions of your images while maintaining aspect ratios:

```cs
using IronPdf;

// Set up renderer
ChromePdfRenderer(renderer = new ChromePdfRenderer();

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Set maximum dimensions for output images
pdf.RasterizeToImageFiles("wikipage_*.png", 500, 500);
```

#### Image Output Specifications

Images are defined with maximum dimensions in width x height format.

<div class="competitors-section__wrapper-even-1">
    <div class="competitors__card" style="width: 48.5%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-portrait.png" alt="Rasterized image from a portrait PDF" class="img-responsive add-shadow">
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">Portrait</p>
    </div>
    <div class="competitors__card" style="width: 50%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-landscape.png" alt="Rasterized image from a landscape PDF" class="img-responsive add-shadow">
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">Landscape</p>
    </div>
</div>