# How to Rasterize a PDF to Images

***Based on <https://ironpdf.com/how-to/rasterize-pdf-to-images/>***


Rasterizing a PDF involves transforming each page of the document into a static image, such as JPEG or PNG formats, where the content is depicted through pixels. This technique is beneficial for displaying PDFs, creating image previews, image-based processing, and ensuring secure, static sharing of documents.

IronPDF provides a straightforward method for converting PDF documents into images programmatically. It is ideal for embedding PDF rendering within your software, generating image previews, conducting image operations, or securing documents.

## Quickstart: Streamline PDF Rasterization in .NET Using IronPDF

IronPDF offers an intuitive API that makes converting PDF pages to images effortless. This quick guide will showcase how to open a PDF and transform each page into an image, enhancing your .NET applications with efficient rasterization capabilities. This method is excellent for creating thumbnails, securing documents, or processing files.

```cs
:title=Transform a PDF into image files with a single command
IronPdf.PdfDocument.FromFile("input.pdf").RasterizeToImageFiles("page_*.png");
```

## Rasterize a PDF to Images Example

The `RasterizeToImageFiles` method, found on the `PdfDocument` object, is designed for converting PDFs to images. This object can handle PDFs sourced from local files or generated from the following guides: [HTML file to PDF](https://ironpdf.com/how-to/html-file-to-pdf/), [HTML string to PDF](https://ironpdf.com/how-to/html-string-to-pdf/), and [URL to PDF](https://ironpdf.com/how-to/url-to-pdf/).

When calling this method, specify the file extension (.png, .jpg, .tif) through the `FileNamePattern` parameter, where the asterisk (*) will be replaced by the corresponding page numbers.

```cs
using IronPdf;

// Create a renderer object
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF from an online source
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Convert the PDF into images
pdf.RasterizeToImageFiles("wikipage_*.png");
```

### Output Folder

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-rasterize.png" alt="Output folder" class="img-responsive add-shadow">
    </div>
</div>

Flatten the PDF to make forms visible in the output images by setting **Flatten** to true. To learn more about editing forms, see: "[How to Fill and Edit PDF Forms](https://ironpdf.com/how-to/edit-forms/)."

### Rasterize to High-Quality Bitmap

For high-resolution outputs, use `ToBitmapHighQuality` instead of `ToBitmap` to avoid JPEG's lossy compression and enjoy the crisp clarity of BMP format, although it leads to larger file sizes.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("url.pdf");

var image = pdf.ToBitmapHighQuality();
image[0].SaveAs("output.png");
```

<hr>

## Advanced Rasterize a PDF to Images Example

### Specifying Image Type

The `RasterizeToImageFiles` method provides options to export as various image types including BMP, JPEG, PNG, GIF, TIFF, and SVG. Each format is supported by a specific method on the PdfDocument object.

```txt
using IronPdf;

// Create a renderer object
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF from an online source
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Rasterize to PNG image files specifying the image type
pdf.RasterizeToImageFiles("wikipage_*.png", IronPdf.Imaging.ImageType.Png);
```

### Define DPI

To enhance image quality, specify a higher DPI setting. 

```cs
using IronPdf;

// Create a renderer object
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF from an online source
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Rasterize images at a higher DPI setting
pdf.RasterizeToImageFiles("wikipage_*.png", DPI: 150);
```

### Set Page Indices

This feature allows the selection of specific pages for rasterization.

```cs
using IronPdf;
using System.Linq;

// Create a renderer object
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF from an online source
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Select and rasterize specific pages
pdf.RasterizeToImageFiles("wikipage_*.png", Enumerable.Range(1, 3));
```

### Adjust Output Image Dimensions

Customize output dimensions while maintaining the document’s aspect ratio.

```cs
using IronPdf;

// Create a renderer object
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF from an online source
PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Specify maximum dimensions for the output images
pdf.RasterizeToImageFiles("wikipage_*.png", 500, 500);
```

#### Output Image Specifications

The output images' dimensions are indicated as width x height, ensuring the correct aspect ratio is preserved.

<div class="competitors-section__wrapper-even-1">
    <div class="competitors__card" style="width: 48.5%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-portrait.png" alt="Image rasterize from a portrait PDF" class="img-responsive add-shadow" >
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">Portrait</p>
    </div>
    <div class="competitors__card" style="width: 50%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-landscape.png" alt="Image rasterize from a landscape PDF" class="img-responsive add-shadow">
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">Landscape</p>
    </div>
</div>