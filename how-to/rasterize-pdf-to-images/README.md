# How to Convert PDF to Image Formats

***Based on <https://ironpdf.com/how-to/rasterize-pdf-to-images/>***


Converting a PDF file to an image format like JPEG or PNG involves transforming each page into a pixel-based representation, where the content is presented as an array of pixels. This technique, known as rasterization, has multiple benefits including displaying PDF contents in image format, creating thumbnails, processing images, and securing document sharing.

IronPDF offers a straightforward way to programmatically convert PDFs into images. This capability is ideal for embedding PDF rendering into your applications, creating image previews, conducting image manipulations, or enhancing document security.

## Example: Converting a PDF to Images

To convert a PDF document into images, use the `RasterizeToImageFiles` method from the **PdfDocument** object. This object allows for the importing and rendering of PDFs from various sources, whether it's a local file or dynamically generated from an [HTML to PDF tutorial](https://ironpdf.com/how-to/html-file-to-pdf/), [HTML string to PDF tutorial](https://ironpdf.com/how-to/html-string-to-pdf/), or [URL to PDF tutorial](https://ironpdf.com/how-to/url-to-pdf/).

You must specify the desired image file format (e.g., .png, .jpg, .tif) in the `FileNamePattern` parameter.

The `*` character in `FileNamePattern` will be replaced with the page number for each image created.

```cs
using IronPdf;
namespace ironpdf.ExampleRasterizeToImage
{
    public class BasicExample
    {
        public void Execute()
        {
            // Create a new renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert URL to PDF
            PdfDocument document = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Convert PDF to Images
            document.RasterizeToImageFiles("wikipage_*.png");
        }
    }
}
```

### Output Image(s)

<div class="center-image-wrapper">
     <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-rasterize.png" alt="Output folder" class="img-responsive add-shadow">
</div>

To ensure that form fields are visible in the images, the PDF should be flattened before conversion, or the **Flatten** parameter should be set to true. After flattening, form fields cannot be detected or edited.

Discover more on editing PDF forms programmatically in "[Editing PDF Forms](https://ironpdf.com/how-to/edit-forms/)."

<hr>

## Advanced Example for Rasterizing Images

Explore additional parameters available for the `RasterizeToImageFiles` method.

### Choosing an Image Format

The method supports multiple image formats, such as BMP, JPEG, PNG, GIF, TIFF, and SVG. You can specify your desired format directly using one of the methods:

- `ToBitmap`: Converts the PDF to IronSoftware.Drawing.Bitmap objects, one per page.
- `ToJpegImages`: Saves the PDF pages as JPEG images.
- `ToPngImages`: Saves the PDF pages as PNG files.
- `ToTiffImages`: Produces single-page TIFF images from the PDF.
- `ToMultiPageTiffImage`: Creates a multi-page TIFF file from the PDF.
- `SaveAsSvg`: Saves the PDF as SVG format.
- `ToSvgString`: Converts a specific PDF page to SVG format as a string.

```cs
using IronPdf;
namespace ironpdf.ExampleRasterizeToImage
{
    public class AdvancedExample
    {
        public void Execute()
        {
            // Create a PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert from URL to PDF
            PdfDocument pdfDoc = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Convert and export PDF pages as PNG images
            pdfDoc.RasterizeToImageFiles("wikipage_*.png", IronPdf.Imaging.ImageType.Png);
        }
    }
}
```

### Selecting DPI for Image Clarity

The default DPI of 96 might cause images to appear blurry. It's important to specify a higher DPI value to improve image clarity.

```cs
using IronPdf;
namespace ironpdf.ExampleRasterizeToImage
{
    public class DPIExample
    {
        public void Execute()
        {
            // Initialize renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Enhance image quality by increasing DPI
            pdf.RasterizeToImageFiles("wikipage_*.png", DPI: 150);
        }
    }
}
```

### Specifying Page Indices

You can specify which pages of the PDF should be converted into images. For example, only rasterizing the first three pages.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.ExampleRasterizeToImage
{
    public class PageSpecificationExample
    {
        public void Execute()
        {
            // Initialize PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Convert specific pages to images
            pdf.RasterizeToImageFiles("wikipage_*.png", Enumerable.Range(1, 3));
        }
    }
}
```

### Custom Image Dimensions

When converting a PDF to images, you can choose the maximum dimensions for the output, which preserves the aspect ratio of the original document. For instance, if specifying a portrait PDF, the exact height will be used while the width adjusts accordingly.

```cs
using IronPdf;
namespace ironpdf.ExampleRasterizeToImage
{
    public class DimensionSpecificationExample
    {
        public void Execute()
        {
            // Initialize the renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert URL to PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Set dimensions and convert to images
            pdf.RasterizeToImageFiles("wikipage_*.png", 500, 500);
        }
    }
}
```

#### Image Dimension Examples

<div class="image-comparison-wrapper">
    <div class="image-item" style="width: 48.5%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-portrait.png" alt="Rasterized image from a portrait PDF" class="responsive-image add-shadow">
        <p style="color: #181818; font-style: italic;">Portrait</p>
    </div>
    <div class="image-item" style="width: 50%;">
        <img src="https://ironpdf.com/static-assets/pdf/how-to/rasterize-pdf-to-images/rasterize-pdf-to-images-image-dimensions-landscape.png" alt="Rasterized image from a landscape PDF" class="responsive-image add-shadow">
        <p style="color: #181818; font-style: italic;">Landscape</p>
    </div>
</div>