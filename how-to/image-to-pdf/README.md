# Transforming Images into PDF Documents

***Based on <https://ironpdf.com/how-to/image-to-pdf/>***


Combining multiple images into a single PDF document is an extremely useful technique, whether for assembling digital portfolios, crafting presentations, or compiling reports. This approach provides a streamlined, universally accessible format that simplifies the sharing and archival of image collections.

With IronPDF, you can effortlessly transform one or more images into a PDF, incorporating unique [image placements and behaviors](https://ironpdf.com/anchor-export-image-behaviors) such as adjusting to page size, centering, and cropping. Additionally, IronPDF enables you to [integrate text and HTML in headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [insert watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf), customize page dimensions, and apply various overlays to enhance the document's appearance and utility.

## Example: Converting a Single Image to PDF

The `ImageToPdfConverter` class offers a simple `ImageToPdf` static method that turns an image into a PDF. This method requires just the image's file path and handles default settings for image placement and behavior smoothly. It supports various image formats like .bmp, .jpeg, .jpg, .gif, .png, .svg, and many others.

### Sample Image

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/meetOurTeam.jpg" alt="Image Sample" class="img-responsive add-shadow">
    </div>
</div>

### Code

```cs
using IronPdf;
namespace ironpdf.ImageToPdf
{
    public class Section1
    {
        public void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            // Convert an image to a PDF
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath);
            
            // Export the PDF
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Example: Converting Multiple Images to PDF

For converting multiple images, provide an `IEnumerable` of file paths instead of a single path. This makes it easy to combine several images into one PDF document.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.ImageToPdf
{
    public class Section2
    {
        public void Run()
        {
            // Retrieve all JPG and JPEG image paths in the 'images' folder.
            IEnumerable<String> imagePaths = Directory.EnumerateFiles("images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            
            // Convert images to a PDF
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePaths);
            
            // Export the PDF
            pdf.SaveAs("imagesToPdf.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imagesToPdf.pdf#zoom=55%" width="100%" height="450px">
</iframe>

<hr>

## Image Placements and Behaviors

IronPDF includes a comprehensive set of image placement and behavior options to tailor your PDF to exact specifications:

- **TopLeftCornerOfPage:** Places the image at the top-left corner.
- **TopRightCornerOfPage:** Aligns the image at the top-right corner.
- **CenteredOnPage:** Centers the image on the page.
- **FitToPageAndMaintainAspectRatio:** Scales the image to fit the page while preserving the aspect ratio.
- Additional placements include **BottomLeftCornerOfPage**, **BottomRightCornerOfPage**, **FitToPage**, and **CropPage**.

```cs
using IronPdf.Imaging;
using IronPdf;
namespace ironpdf.ImageToPdf
{
    public class Section3
    {
        public void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            // Convert an image to a PDF with image behavior of centered on page
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, ImageBehavior.CenteredOnPage);
            
            // Export the PDF
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}
```

### Image Behaviors Comparison

A detailed display of images shows the different placement behaviors. This can be seen through various example placements, each demonstrating how IronPDF can customize the positioning of images within your PDF document.

<hr>

## Rendering Options

By employing the `ImageToPdf` static method and incorporating images with HTML `<img>` tags, converting a variety of images into a PDF is made seamless. Advanced customization is possible with the inclusion of the `ChromePdfRenderOptions` object, specifying features like HTML headers or footers directly.

```cs
using IronPdf;
namespace ironpdf.ImageToPdf
{
    public class Section4
    {
        public void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            ChromePdfRenderOptions options = new ChromePdfRenderOptions()
            {
                HtmlHeader = new HtmlHeaderFooter()
                {
                    HtmlFragment = "<h1 style='color: #2a95d5;'>Content Header</h1>",
                    DrawDividerLine = true,
                },
            };
            
            // Convert an image to a PDF with custom header
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, options: options);
            
            // Export the PDF
            pdf.SaveAs("imageToPdfWithHeader.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/image-to-pdf/imageToPdfWithHeader.pdf#zoom=55%" width="100%" height="450px">
</iframe>

For details on converting or rasterizing PDF documents back into images, please refer to our [comprehensive guide](https://ironpdf.com/how-to/rasterize-pdf-to-images/).