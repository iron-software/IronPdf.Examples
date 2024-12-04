# How to Embed Images into PDF Documents

***Based on <https://ironpdf.com/how-to/add-images-to-pdfs/>***


Embedding images directly into PDF files ensures that the images are integral to the PDFs, eliminating dependencies on external sources. This feature allows the images to be viewed seamlessly within the PDF, even if it's used offline.

IronPDF excellently supports turning HTML content, which includes images, into PDF documentation. This is achieved by embedding images into HTML code and converting that HTML into a PDF file.

## Embed Image in PDF Example

To incorporate an image into a PDF, start by embedding the image using the `<img>` tag within your HTML code. Then, apply the `RenderHtmlAsPdf` method from IronPDF to transform your HTML into a PDF. If you're modifying an already existing PDF, you can overlay the image onto your document using tools described in the [image stamper or HTML stamper guide](https://ironpdf.com/how-to/custom-watermark/).

```cs
using IronPdf;
namespace ironpdf.AddImagesToPdfs
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // HTML string with image link
            string html = @"<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>";
            
            // Convert HTML string to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Output PDF file
            pdf.SaveAs("embedImage.pdf");
        }
    }
}
```

<hr>

## Embed using Base64 Encoding Example

To encode an image in base64 format for embedding in HTML, acquire the binary data from the image via file reading or a network request. Utilize the `Convert.ToBase64String` method from Microsoft .NET to transform this binary data into a base64 string. Following this, create your HTML `<img>` tag by prefixing the base64 string with "data:image/svg+xml;base64," to denote the image type. For additional details about image formats, refer to [MDN Web Docs on Image Formats](https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types).

```cs
using System.IO;
using IronPdf;
namespace ironpdf.AddImagesToPdfs
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Read image and convert to binary data
            byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");
            
            // Convert binary data to a base64 string
            string imgDataUri = Convert.ToBase64String(binaryData);
            
            // Create HTML with image embedded
            string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";
            
            // Convert HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Save the generated PDF
            pdf.SaveAs("embedImageBase64.pdf");
        }
    }
}
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/add-images-to-pdfs/embedImageBase64.pdf" width="100%" height="400px">
</iframe>