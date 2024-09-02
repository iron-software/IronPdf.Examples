# Converting PDF to Images Using IronPDF

Converting a PDF to image formats such as JPEG or PNG is known as rasterization. This procedure turns each PDF page into a raster image where its contents are displayed as pixels. Rasterizing is especially useful for tasks like rendering PDFs visibly, crafting image thumbnails, processing images, and securely sharing documents.

IronPDF streamlines the process of converting PDFs into images, enabling developers to embed PDF visualization in applications, create image previews, manage image-based operations, and improve document security effectively.

## Example: Rasterizing PDF to Images

IronPDF's `RasterizeToImageFiles` function allows for the conversion of PDF documents into image files. This function can be accessed through the **PdfDocument** class when handling PDF files, whether they are loaded from a local file, converted from an [HTML file](https://ironpdf.com/how-to/html-file-to-pdf/), an [HTML string](https://ironpdf.com/how-to/html-string-to-pdf/), or a [web URL](https://ironpdf.com/how-to/url-to-pdf/).

You must specify the desired image file format (e.g., .png, .jpg, .tif) using the `FileNamePattern` parameter, where the asterisk (*) in the file name pattern will be replaced by the page number.

```cs
using IronPdf;

// Initialize the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert a web URL to a PDF document
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Convert the PDF to images, naming the files as 'wikipage_page#.png'
pdf.RasterizeToImageFiles("wikipage_*.png");
```

### Displaying Output Image Files

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-rasterize.png" alt="Output folder displaying images" class="img-responsive add-shadow">
    </div>
</div>

Before converting a PDF with form fields into an image, flatten the PDF using the `Flatten` method to ensure all form fields are visible in the images. This process makes forms non-editable.

Explore more about managing PDF forms in our guide: "[How to Fill and Edit PDF Forms](https://ironpdf.com/how-to/edit-forms/)."

<hr>

## Advanced Rasterization Techniques

### Choosing the Image Format

IronPDF provides support for several image formats. You can specify your preferred format using the parameters in `RasterizeToImageFiles` method. Supported image types include BMP, JPEG, PNG, GIF, TIFF, and SVG. Each format can be specifically rendered and saved using dedicated methods:

- `ToBitmap`: Creates a bitmap for each PDF page.
- `ToJpegImages`: Saves each PDF page as a JPEG image.
- `ToPngImages`: Saves each PDF page as a PNG image.
- `ToTiffImages`: Each PDF page is saved as a TIFF image.
- `ToMultiPageTiffImage`: Combines all PDF pages into a multipage TIFF image.
- `SaveAsSvg`: Converts the entire PDF into SVG format.
- `ToSvgString`: Converts a specific PDF page to SVG string format.

```cs
using IronPdf;

// Initialize the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert a web URL to a PDF document
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Save the PDF as a PNG image, specifying the image type
pdf.RasterizeToImageFiles("wikipage_*.png", IronPdf.Imaging.ImageType.Png);
```

### Adjusting Image Quality

To enhance the quality of the output images, adjust the DPI setting. A higher DPI leads to sharper images.

```cs
using IronPdf;

// Initialize the renderer
ChromePdfRenderer renderer = a new ChromePdfRenderer();

// Convert the URL to a PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Export the PDF to images with improved resolution
pdf.RasterizeToImageFiles("wikipage_*.png", DPI: 150);
```

### Specifying Pages for Rasterization

You can select specific PDF pages for conversion into images.

```cs
using IronPdf;
using System.Linq;

// Instantiate the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert a URL to a PDF document
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Generate images for specific pages (#1 to #3)
pdf.RasterizeToImageFiles("wikipage_*.png", Enumerable.Range(1, 3));
```

### Customizing Image Dimensions

IronPDF allows you to customize the dimensions of the output images while preserving the aspect ratio of the original PDF.

```cs
using IronPdf;

// Initialize the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Convert the URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Set the custom dimensions for the image output
pdf.RasterizeToImageFiles("wikipage_*.png", 500, 500);
```

#### Output Image Specifications

The dimensions for output images are set using the width x height format.

<div class="competitors-section__wrapper-even-1">
    <div class="competitors__card" style="width: 48.5%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-portrait.png" alt="Rasterized image from a portrait-oriented PDF" class="img-responsive add-shadow">
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">Portrait</p>
    </div>
    <div class="competitors__card" style="width: 50%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-landscape.png" alt="Rasterized image from a landscape-oriented PDF" class="img-responsive add-shadow">
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">Landscape</p>
    </div>
</div