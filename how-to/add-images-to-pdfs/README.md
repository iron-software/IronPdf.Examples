# How to Add Images to PDFs

***Based on <https://ironpdf.com/how-to/add-images-to-pdfs/>***


Embedding images directly into a PDF document is a fundamental practice for making the PDF self-contained and independent of external resources. This technique guarantees the consistent display of the image, irrespective of the availability of internet access.

IronPDF offers the capability to take HTML content, including inline images, and turn it into a PDF document. This is an ideal approach for integrating images directly into PDFs.

**Start Using IronPDF Today!**

## Example of Image Embedding in PDF

To incorporate an image into a PDF, begin by using the `<img>` tag to include the image within your HTML content. After that, apply the `RenderHtmlAsPdf` function from IronPDF to transform the HTML into a PDF. For those already working with an existing PDF, applying an image directly onto it can be achieved through tools found in our [image or HTML stamper guide](https://ironpdf.com/how-to/custom-watermark/).

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

string html = @"<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>";

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the PDF file
pdf.SaveAs("embedImage.pdf");
```

## Example Using Base64 to Embed Images

To embed an image using base64 encoding, start by fetching the image's binary data, which could come from reading a file or through a network request. Use the `Convert.ToBase64String` function provided by .NET to encode the binary data. Place the base64 string inside a `<img>` tag with the correct image MIME type prefix, such as "data:image/svg+xml;base64,". For additional reading on specific image formats and data types, the [MDN Web Docs on Image Formats](https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types) is a helpful resource.


```cs
using IronPdf;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Load binary data from the image file
byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");

// Encode the binary data to base64
string imgDataUri = Convert.ToBase64String(binaryData);

// Create HTML with embedded image
string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";

// Transform the HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the generated PDF
pdf.SaveAs("embedImageBase64.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/add-images-to-pdfs/embedImageBase64.pdf" width="100%" height="400px">
</iframe>