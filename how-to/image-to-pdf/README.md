# How to Convert Images to a PDF

***Based on <https://ironpdf.com/how-to/image-to-pdf/>***


Combining several image files, such as JPG, PNG, or TIFF, into a single PDF document facilitates the creation of digital portfolios, presentations, or reports. This approach simplifies the sharing and archival of images in a universally accessible format.

IronPDF provides capabilities to transform one or multiple images into a PDF, featuring various [image placement and behavior options](#anchor-export-image-behaviors) such as fitting, centering, and cropping the images on the page. Additionally, IronPDF supports enhancing PDFs with [headers and footers containing text and HTML](https://ironpdf.com/how-to/headers-and-footers/), adding [watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf), customizing page dimensions, and applying background or foreground layers.


### Getting Started with IronPDF

---

## Example: Converting an Image to a PDF

The `ImageToPdf` static method in the **ImageToPdfConverter** class simplifies the conversion of an image into a PDF document. This method necessitates just the image file path and automates its transformation into a PDF with standard settings. Supported formats include .bmp, .jpeg, .jpg, and many others.

### Image Example

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/meetOurTeam.jpg" alt="Sample Image" class="img-responsive add-shadow">
    </div>
</div>

### Sample Code

```cs
using IronPdf;

string imagePath = "meetOurTeam.jpg";

// Transform the image into a PDF document
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath);

// Save the resulting PDF
pdf.SaveAs("imageToPdf.pdf");
```

### PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

---

## Example: Converting Multiple Images to a PDF

To convert multiple images into a single PDF document, use an **IEnumerable** sequence containing the image paths. This method also preserves the default image settings during conversion.

```cs
using IronPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Gather paths of JPG and JPEG images in the 'images' folder.
IEnumerable<String> imagePaths = Directory.EnumerateFiles("images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));

// Convert these images into a PDF document
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePaths);

// Save the completed PDF
pdf.SaveAs("imagesToPdf.pdf");
```

### PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imagesToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

---

## Image Placement and Behavior Options

IronPDF allows a variety of image placement and behavior settings to tailor the PDF appearance:

- **TopLeftCornerOfPage:** Positions the image at the page's top-left corner.
- **TopRightCornerOfPage:** Aligns the image at the top-right.
- **CenteredOnPage:** Centers the image on the page.
- **FitToPageAndMaintainAspectRatio:** Scales the image to fit the page while preserving its aspect ratio.
- **BottomLeftCornerOfPage:** Places the image at the bottom-left corner.
- **BottomRightCornerOfPage:** Positions the image at the bottom-right.
- **FitToPage:** Stretches the image to fill the entire page.
- **CropPage:** Adjusts the page size to match the image dimensions.

### Sample Image Behaviors

<table class="table" style="text-align: center; background-color: #f1f9fb;">
    <!-- Table content with images showing placement examples -->
</table>

---

## Custom Rendering Options

The `ImageToPdf` method can import images using HTML `<img>` tags, which allows the HTML to PDF conversion process. The **ChromePdfRenderOptions** can be used to alter rendering settings.

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

// Create a PDF with a custom header from an image
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, options: options);

// Output the custom PDF
pdf.SaveAs("imageToPdfWithHeader.pdf");
```

### PDF with Custom Header

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdfWithHeader.pdf#zoom=55%" width="100%" height="450px">
</iframe>

For further guidance on converting PDF documents into images, refer to our [tutorial on rasterizing PDFs into images](https://ironpdf.com/how-to/rasterize-pdf-to-images/).