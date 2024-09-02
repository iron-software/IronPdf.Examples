# How to Insert Images into PDFs

Inserting images into a PDF embeds them directly inside the file, ensuring they are self-contained and making them viewable without needing any external files or internet access. This ensures that the image appears as part of the PDF itself.

IronPDF excels in converting HTML strings, files, and web URLs directly into PDFs. Through this process, images embedded in HTML can be seamlessly transitioned into a PDF format.

## Example: Embedding an Image in a PDF

To include an image in a PDF, start by incorporating it into an HTML snippet using the `<img>` tag. Then, employ the `RenderHtmlAsPdf` method to transform the HTML snippet into a PDF. If editing an existing PDF, you can insert the image by using a [stamper for images or HTML](https://ironpdf.com/how-to/custom-watermark/).

```cs
using IronPdf;

// Initialize a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// HTML with an image source
string html = @"<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>";

// Converting HTML to a PDF document
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Saving the generated PDF
pdf.SaveAs("embedImage.pdf");
```

<hr>

## Example: Using Base64 for Image Embedding

Embedding an image using base64 involves converting the image to a base64 string. The `Convert.ToBase64String` method in the Microsoft .NET framework is ideal for this task. Start by obtaining the image’s binary data—either by loading a file or via a network—and then embed it using a base64 data URI in the HTML img tag. The type of image (e.g., SVG, PNG) is indicated just prior to the base64 string. More details on image types can be found on the [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types).

```cs
using IronPdf;
using System;
using System.IO;

// Creating a new PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Reading image file data into binary form
byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");

// Encoding the binary data to base64
string imgDataUri = Convert.ToBase64String(binaryData);

// Constructing HTML with embedded base64 image data
string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";

// Converting the HTML with embedded image to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Saving the PDF with the embedded image
pdf.SaveAs("embedImageBase64.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/add-images-to-pdfs/embedImageBase64.pdf" width="100%" height="400px">
</iframe>