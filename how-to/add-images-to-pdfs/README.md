# How to Incorporate Images into PDFs

***Based on <https://ironpdf.com/how-to/add-images-to-pdfs/>***


Incorporating an image directly within a PDF file means the image is placed directly inside the PDF, allowing for it to be entirely self-contained. This ensures that the PDF can display the image perfectly, regardless of internet connectivity, as it does not depend on external resources.

IronPDF excels at transforming HTML strings, files, and web URLs into PDFs. Utilizing this technique, images embedded in HTML can be effectively transformed into a self-contained PDF document.

## Quickstart: Effortlessly Embed Images into PDFs

Begin embedding images in your PDF documents using IronPDF in .NET C#. By converting your image into a Base64 string and embedding it within an HTML `<img>` tag, you create a self-sufficient PDF document which does not depend on any external resources. This approach guarantees that your images are displayed flawlessly without the necessity of an internet connection, streamlining the embedding process.

```cs
:title=Single line image embedding in a PDF!
new IronPdf.ChromePdfRenderer()
     .RenderHtmlAsPdf("<img src='data:image/png;base64," + Convert.ToBase64String(File.ReadAllBytes("logo.png")) + "'>")
     .SaveAs("image-embedded.pdf");
```

## Example of Image Embedding in PDF

To incorporate an image into a PDF, start by embedding the image in HTML using the `<img>` tag. Next, apply the `RenderHtmlAsPdf` method to convert the HTML into a PDF. For those who already have a PDF and wish to add an image, refer to the detailed guide found here: [image stamper or HTML stamper tutorial](https://ironpdf.com/how-to/custom-watermark/).

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

string html = @"<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>";

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the PDF
pdf.SaveAs("embedImage.pdf");
```

<hr>

## Base64 Image Embedding Example

To embed an image using base64 in HTML, start by accessing the binary data from the image file or via a network request. Utilize the `Convert.ToBase64String` method from Microsoft .NET to change this binary data into a base64 string. Create an HTML image tag with "data:image/svg+xml;base64," preceding the base64 string. To understand more about specifying the image type alongside the base64 string, please visit the [MDN Web Docs on Image Formats](https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types).

```csharp
using IronPdf;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Load image file binary data
byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");

// Encode the binary data to base 64
string imgDataUri = Convert.ToBase64String(binaryData);

// Construct HTML with embedded image
string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";

// Transform HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Store the PDF
pdf.SaveAs("embedImageBase64.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/add-images-to-pdfs/embedImageBase64.pdf" width="100%" height="400px">
</iframe>

To explore more capabilities, visit our tutorial page here: [Additional Features](https://ironpdf.com/tutorials/pdf-assets-and-performance-csharp/)