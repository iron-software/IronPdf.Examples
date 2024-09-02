# Transforming Images into PDF Documents

Turning your image collections—such as JPG, PNG, or TIFF formats—into PDF documents is an effective way to compile digital portfolios, presentations, and reports. This consolidation simplifies both sharing and archiving volumes of images in a more universally accessible format.

Using IronPdf, you can convert both single and multiple images into a PDF while controlling [image placements and behaviors](#anchor-export-image-behaviors). These configurations include adjustments like fitting to the page, centering, and cropping. You also have the flexibility to [add text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [introduce watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf), customize page sizes, or incorporate background and foreground overlays.

## Sample Conversion: Single Image to PDF

To convert an image to a PDF, leverage the `ImageToPdf` static method from the **ImageToPdfConverter** class. This method simply requires the image's file path, seamlessly converting it to a PDF with preset configurations for image handling. Supported image formats include .bmp, .jpeg, .jpg, .gif, and several others.

### Example Image

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/meetOurTeam.jpg" alt="Image Sample" class="img-responsive add-shadow">
    </div>
</div>

### Conversion Code

```cs
using IronPdf;

string imagePath = "meetOurTeam.jpg";

// Initiate the conversion of image to PDF
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath);

// Save the PDF
pdf.SaveAs("imageToPdf.pdf");
```

### Resulting PDF Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Example: Converting Multiple Images to PDF

When converting multiple images, use an **IEnumerable** to list image file paths. This allows for bulk conversion with default settings for image placement.

```cs
using IronPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Collect all JPG and JPEG images within the 'images' directory.
IEnumerable<String> imagePaths = Directory.EnumerateFiles("images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));

// Execute the conversion
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePaths);

// Save the newly created PDF
pdf.SaveAs("imagesToPdf.pdf");
```

### Resulting PDF of Multiple Images

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imagesToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Overview of Image Placement and Behavior Options

IronPdf provides several options for image placement and handling within PDFs:

- **TopLeftCornerOfPage:** Positions the image at the top-left corner.
- **TopRightCornerOfPage:** Places the image at the top-right corner.
- **CenteredOnPage:** Centers the image on the page.
- **FitToPageAndMaintainAspectRatio:** Fits the image to the page, preserving its aspect ratio.
- **BottomLeftCornerOfPage:** Aligns the image at the bottom-left.
- **BottomRightCornerOfPage:** Sets the image at the bottom-right.
- **FitToPage:** Stretches the image to fill the page.
- **CropPage:** Adjusts the page dimensions to the image.

```cs
using IronPdf;
using IronPdf.Imaging;

string imagePath = "meetOurTeam.jpg";

// Convert the image with a specific behavior setting
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, ImageBehavior.CenteredOnPage);

// Output the final PDF
pdf.SaveAs("imageToPdf.pdf");
```

### Image Behavior Visualization

| Placement Options |
| :---: |
| ![TopLeftCornerOfPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/TopLeftCornerOfPage.webp) Top Left |
| ![TopRightCornerOfPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/TopRightCornerOfPage.webp) Top Right |
| ![CenteredOnPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/CenteredOnPage.webp) Centered |
| ![FitToPageAndMaintainAspectRatio](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/FitToPageAndMaintainAspectRatio.webp) Fit to Page (Aspect Ratio) |
| ![BottomLeftCornerOfPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/BottomLeftCornerOfPage.webp) Bottom Left |
| ![BottomRightCornerOfPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/BottomRightCornerOfPage.webp) Bottom Right |
| ![FitToPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/FitToPage.webp) Fit to Entire Page |
| ![CropPage](https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/CropPage.webp) Crop to Image |

<hr>

## Advanced Rendering Options

Underneath, `ImageToPdf` method models an image using an HTML `img` tag, which allows subsequent conversion of HTML content to PDF. Here, inserting a `ChromePdfRenderOptions` object can tailor the rendering entirely.

```cs
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

// Customize and convert image to PDF
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, options: options);

// Save the PDF with custom settings
pdf.SaveAs("imageToPdfWithHeader.pdf");
```

### Enhanced PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdfWithHeader.pdf#zoom=55%" width="100%" height="450px">
</iframe>

For further guidance on converting or rendering PDF documents into images, refer to our [How to Rasterize a PDF to Image](https://ironpdf.com/how-to/rasterize-pdf-to-images/) guide.