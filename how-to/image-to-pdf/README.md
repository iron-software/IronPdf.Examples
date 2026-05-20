# How to Convert Images to a PDF

***Based on <https://ironpdf.com/how-to/image-to-pdf/>***


Combining various image files like JPG, PNG, or TIFF into a single PDF document simplifies the task of organizing and sharing a coherent collection of images. This is especially beneficial for compiling digital portfolios, presentations, or structured reports as it enhances accessibility and storage efficiency.

IronPDF enables the conversion of one or multiple images into a PDF with a variety of [image placements and behavior options](#anchor-export-image-behaviors). Utilize features like full-page fitting, center alignment, and cropping to tailor the document to your needs. You can also enrich your document by adding [text and HTML headers and footers with IronPDF](https://ironpdf.com/how-to/headers-and-footers/), [overlaying watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf), setting custom page dimensions, and embedding background and foreground content.

*as-heading:2(Quickstart: Convert Images to PDF with IronPDF)*

Seamlessly transform images into a PDF document using IronPDF's `ImageToPdfConverter` class. This guide exemplifies how you can swiftly convert an image into a PDF, facilitating the inclusion of image-to-PDF conversion in your .NET C# applications. The streamlined process ensures a fluid and effective pathway for producing digital compilations.

```cs
:title=Convert image(s) to PDF in one line!
IronPdf.ImageToPdfConverter.ImageToPdf("path/to/image.png").SaveAs("imageToPdf.pdf");
```

## Convert Image to PDF Example

To convert an individual image into a PDF, use the `ImageToPdf` static method from the `ImageToPdfConverter` class. This method demands just the image's file path to turn it into a PDF with standard image positioning and behavior. The following image formats are supported: `.bmp`, `.jpeg`, `.jpg`, `.gif`, `.png`, `.svg`, `.tif`, `.tiff`, `.webp`, `.apng`, `.avif`, `.cur`, `.dib`, `.ico`, `.jfif`, `.jif`, `.jpe`, `.pjp`, `.pjpeg`.

### Sample Image

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/meetOurTeam.jpg" alt="Image Sample" class="img-responsive add-shadow">
    </div>
</div>

### Code

```csharp
using IronPdf;

string imagePath = "meetOurTeam.jpg";

// Convert an image to a PDF
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath);

// Export the PDF
pdf.SaveAs("imageToPdf.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Convert Multiple Images to PDF Example

Convert a collection of images into a PDF by providing an `IEnumerable` of file paths rather than just one. This technique reproduces a PDF with default settings for image alignment and behavior.

```csharp
using IronPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Locate all JPG and JPEG image paths in the 'images' folder.
IEnumerable<String> imagePaths = Directory.EnumerateFiles("images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));

// Construct a PDF from these images
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePaths);

// Save the new PDF
pdf.SaveAs("imagesToPdf.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imagesToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Image Placements and Behaviors

IronPDF offers diverse image positioning and handling strategies to enhance PDF output:

- **TopLeftCornerOfPage:** Positions the image at the top left.
- **TopRightCornerOfPage:** Aligns the image at the top right.
- **CenteredOnPage:** Centers the image on the page.
- **FitToPageAndMaintainAspectRatio:** Scales the image to fit while preserving the original aspect ratio.
- **BottomLeftCornerOfPage:** Places the image at the bottom left.
- **BottomRightCornerOfPage:** Sets the image at the bottom right.
- **FitToPage:** Scales the image to cover the entire page.
- **CropPage:** Crops the page dimensions to match the image.

### Image Behaviors Comparison

This comparison table illustrates the effects of each positioning strategy, providing clear visualization:

<table class="table" style="textAlign: center; backgroundColor: #f1f9fb;">
    <!-- Rows with sample images showing different placements and behaviors -->
</table>

## Rendering Options Explored

Underlying IronPDF’s ability to turn image files into PDF documents is an advanced rendering process. Essentially, images are imported as HTML `<img>` tags, which are then converted into PDFs. Customizations in this process are facilitated by passing a `ChromePdfRenderOptions` object.

```csharp
using IronPdf;

string imagePath = "meetOurTeam.jpg";

ChromePdfRenderOptions options = new ChromePdfRenderOptions()
{
    HtmlHeader = new HtmlHeaderFooter()
    {
        HtmlFragment = "<h1 style='color: #2a95d5;'>Content Header</h1>",
        DrawDividerLine = true,
    },
};

// Transform an image into a PDF with a custom header
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, options: options);

// Download the augmented PDF
pdf.SaveAs("imageToPdfWithHeader.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdfWithHeader.pdf#zoom=55%" width="100%" height="450px">
</iframe>

Explore more about converting or rasterizing PDF documents into images by checking our [guide on rasterizing PDFs into images](https://ironpdf.com/how-to/rasterize-pdf-to-images/).

Ready to explore more functionalities? Dive into our [PDF conversion tutorials](https://ironpdf.com/tutorials/convert-pdf/).