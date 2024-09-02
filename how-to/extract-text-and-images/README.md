# How to Retrieve Text and Graphics from PDF Documents

<div class="alert alert-info iron-variant-1" role="alert">
	Is your organization spending excessively on annual PDF security and compliance subscriptions? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, offering a one-time payment solution for services like digital signatures, redaction, encryption, and protection. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Give it a try</a>
</div>

Retrieving text and images from PDF files entails accessing the embedded textual and graphical content. This is crucial for repurposing these elements, whether it's for text editing, conversions to different formats, or saving images for further use or analysis.

For such operations, IronPdf is an effective tool. Once extracted, images can be stored on your local disk in a different format or used in new documents you create.

## Example of Text Extraction

This operation is feasible with both new and existing PDF documents. The `ExtractAllText` method is designed to pull out all text embedded within a PDF, returning a single string where pages are delineated by four consecutive `Environment.NewLines`. Below, we demonstrate this with a [sample PDF](https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/sample.pdf) sourced from the Wikipedia.

```cs
using IronPdf;
using System.IO;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text
string text = pdf.ExtractAllText();

// Save the extracted text to a file
File.WriteAllText("extractedText.txt", text);
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text.webp" alt="Extracted text" class="img-responsive add-shadow">
    </div>
</div>

### Detailed Text Extraction by Line and Character

It's also feasible to pull text details such as the coordinates of lines and characters from a specific PDF page. Extracting these details involves selecting a page and accessing its **Lines** and **Characters** properties, where coordinates are noted as Top, Right, Bottom, and Left.

```cs
using IronPdf;
using System.IO;
using System.Linq;

// Open the PDF file
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Detail extraction of text by lines
var lines = pdf.Pages[0].Lines;

// Extract specific character details
var characters = pdf.Pages[0].Characters;

File.WriteAllLines("lines.txt", lines.Select(l => $"at Y={l.Bottom:F2}: {l.Contents}"));
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text-by-line-character.webp" alt="Extracted text by line and character" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Example of Image Extraction

To extract all images embedded within a PDF, you can use the `ExtractAllImages` method. This function retrieves images as a list of `AnyBitmap` objects. Here, images are extracted from the same document used in the previous examples and are then saved to a designated folder.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Get images
var images = pdf.ExtractAllImages();

for(int i = 0; i < images.Count; i++)
{
    // Save each image
    images[i].SaveAs($"images/image{i}.png");
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-images.webp" alt="Extracted images" class="img-responsive add-shadow">
    </div>
</div>

Additional methods such as `ExtractAllBitmaps` and `ExtractAllRawImages` allow for varied forms of image extraction, yielding images as either AnyBitmap objects or raw byte arrays, respectively.

<hr>

## Specific Page Text and Image Extraction

For precise content extraction, you can target specific pages. The `ExtractTextFromPage` and `ExtractTextFromPages` methods allow for text extraction from single or multiple pages. Similarly, `ExtractImagesFromPage` and `ExtractImagesFromPages` are available for image extraction tasks.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text from the first page
string textFromPage1 = pdf.ExtractTextFromPage(0);

int[] pages = new[] { 0, 2 };

// Extract text from the first and third pages
string textFromPage1_3 = pdf.ExtractTextFromPages(pages);
```

This guide showcases how to leverage IronPdf to efficiently extract and utilize both text and graphical content from PDF documents.