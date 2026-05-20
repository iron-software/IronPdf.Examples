# How to Retrieve Text and Images from PDF Documents

***Based on <https://ironpdf.com/how-to/extract-text-and-images/>***


<div class="alert alert-info iron-variant-1" role="alert">
Reduce your yearly expenditures on PDF security and compliance by considering <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, an all-inclusive solution for SaaS services such as digital signing, redaction, encryption, and protection, available with a one-time payment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Discover More About IronSecureDoc</a>
</div>

Retrieving text and images from PDF files is essential for accessing and leveraging content within these documents, enabling editing, searching, or further content analysis. This can be particularly useful when converting text to different formats or saving images for further examination or reuse.

IronPdf is the tool for this task. This library facilitates the extraction of text and images from PDFs, allowing them to be saved or converted and utilized in new documents.

*as-heading:2(Beginners Guide: Extract Text and Images Using IronPDF)*

With IronPDF, extracting text and images from PDF documents is straightforward and requires only a few lines of code. This guide provides developers with the necessary know-how to extract information from PDFs, aiding in content repurposing and analysis. Whether you need the text for editing purposes or wish to preserve images, IronPDF offers an efficient solution for managing PDF contents. Start using the IronPdf library today for an effortless PDF handling experience.

```cs
:title=Efficiently Retrieve Content from PDFs
var pdfDocument = new IronPdf.PdfDocument("sample.pdf");
string extractedText = pdfDocument.ExtractAllText();
var extractedImages = pdfDocument.ExtractAllImages();
```

## Example of Text Extraction

Text can be extracted from PDF documents that are either newly created or existing ones. To do this, utilize the `ExtractAllText` method, which pulls all text content from the document, with a separation of four consecutive newlines between pages. Here is an example using a [sample PDF](https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/sample.pdf) derived from a Wikipedia article.

```csharp
using IronPdf;
using System.IO;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Extract text
string entireText = document.ExtractAllText();

// Save the extracted text
File.WriteAllText("extractedText.txt", entireText);
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text.webp" alt="Extracted text" class="img-responsive add-shadow">
    </div>
</div>

### Detailed Text Extraction

This method enables the extraction of text by lines and individual characters, provided with their coordinates within the PDF. By selecting a specific PDF page, you can access its `Lines` and `Characters` properties to get detailed text positioning information.

```csharp
using IronPdf;
using System.IO;
using System.Linq;

// Open PDF document
PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Extract text line by line
var lineData = document.Pages[0].Lines;

// Extract character details
var characterData = document.Pages[0].Characters;

File.WriteAllLines("detailedText.txt", lineData.Select(l => $"at Y={l.BoundingBox.Bottom:F2}: {l.Contents}"));
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text-by-line-character.webp" alt="Extracted text by line and character" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Image Extraction Overview

The `ExtractAllImages` method is used to retrieve all visuals from the PDF. As an illustration, images pulled from the previously mentioned document are stored in the 'images' folder.

```csharp
using IronPdf;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Retrieve all images
var allImages = document.ExtractAllImages();

for (int index = 0; index < allImages.Count; index++)
{
    // Save each image
    allImages[index].SaveAs($"images/image{index}.png");
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-images.webp" alt="Extracted images" class="img-responsive add-shadow">
    </div>
</div>

For variant methods of image extraction, `ExtractAllBitmaps` and `ExtractAllRawImages` offer functionalities to pull image data as formatted bitmaps and raw byte arrays respectively.

<hr>

## Page-Specific Content Extraction

The capability to extract text and images from specific pages enhances targeted content retrieval. The `ExtractTextFromPage` method and `ExtractTextFromPages` option facilitate text extraction from selected pages. For images, the `ExtractImagesFromPage` and `ExtractImagesFromPages` methods are used.

```csharp
using IronPdf;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Extract text from the first page
string pageOneText = document.ExtractTextFromPage(0);

int[] specifiedPages = new[] { 0, 2 };

// Extract text from the first and third pages
string selectedPagesText = document.ExtractTextFromPages(specifiedPages);
```