# How to Retrieve Text and Images from Embedded PDF Content

***Based on <https://ironpdf.com/how-to/extract-text-and-images/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Is your company overspending on annual subscriptions for PDF management? Consider <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for a cost-effective, one-time payment solution that includes digital signatures, document redaction, encryption, and security measures. <a href="https://ironsoftware.com/enterprise/securedoc/docs/"> View IronSecureDoc Documentation</a>
</div>

Extracting embedded text and images from PDFs enables users to access and repurpose these elements for various uses like editing, searching, or converting textual content into different formats and reutilizing images for analysis or other applications.

To perform this extraction, you can utilize IronPdf where text and images can be retained and saved or transformed into other file types and incorporated into new documents.

<h3>Begin Using IronPDF</h3>

--------------------------------------

## Example of Text Extraction

Text extraction can easily be executed on PDFs whether they are newly created or pre-existing documents. To retrieve all embedded text, apply the `ExtractAllText` method which outputs a string encapsulating all text found in the PDF. Pages are segregated by appending four consecutive `Environment.NewLines`.

Here's a demonstration using a [sample PDF](https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/sample.pdf) originated from the Wikipedia site.

```cs
using IronPdf;
using System.IO;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve text from PDF
string text = pdf.ExtractAllText();

// Save the extracted text to an external file
File.WriteAllText("extractedText.txt", text);
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text.webp" alt="Extracted text" class="img-responsive add-shadow">
    </div>
</div>

### Text Extraction by Lines and Characters

Individual lines and characters within a page of a PDF can also be identified and retrieved. Begin by selecting a page and accessing its **Lines** and **Characters** properties to fetch text along with their coordinates.

```cs
using IronPdf;
using System.IO;
using System.Linq;

// Load PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve text by line
var lines = pdf.Pages[0].Lines;

// Retrieve text by character
var characters = pdf.Pages[0].Characters;

// Save the lines to a text file, noting the coordinates
File.WriteAllLines("lines.txt", lines.Select(l => $"at Y={l.BoundingBox.Bottom:F2}: {l.Contents}"));
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text-by-line-character.webp" alt="Extracted text by line and character" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Example of Image Extraction

To extract images from a PDF, utilize the `ExtractAllImages` method which provides the images as a collection of AnyBitmap objects. Reference the same document as in previous examples.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve all images
var images = pdf.ExtractAllImages();

// Save images individually
for(int i = 0; i < images.Count; i++)
{
    // Save each image to a designated folder
    images[i].SaveAs($"images/image{i}.png");
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-images.webp" alt="Extracted images" class="img-responsive add-shadow">
    </div>
</div>

Besides `ExtractAllImages`, explore `ExtractAllBitmaps` and `ExtractAllRawImages` which give insights into other methods of retrieving images as Bitmaps or raw Byte Arrays respectively.

<hr>

## Text and Images Extraction by Page

You can pinpoint the extraction to single or several specified pages within a PDF. For extracting text, employ `ExtractTextFromPage` and `ExtractTextFromPages`; for images, `ExtractImagesFromPage` and `ExtractImagesFromPages` are at your disposal.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text from the first page
string textFromPage1 = pdf.ExtractTextFromPage(0);

int[] pages = new[] { 0, 2 };

// Extract text from multiple specified pages
string textFromPage1_3 = pdf.ExtractTextFromPages(pages);
```