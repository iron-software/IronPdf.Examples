# How to Extract Embedded Text and Images from PDFs

***Based on <https://ironpdf.com/how-to/extract-text-and-images/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Looking to cut expenses on yearly PDF security and compliance subscriptions? Take a look at <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>. This platform offers comprehensive services such as digital signing, document redaction, encryption, and protection under a one-time payment plan. Get to know more by visiting the <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc Documentation</a>.
</div>

The process of extracting embedded text and images from PDFs is critical for accessing and repurposing document content. This allows the extracted text and graphics to be edited, searched, or converted to other formats, and permits the images to be saved for further use or analysis.

To proceed with this operation, we utilize IronPdf to facilitate the extraction of images and text from PDF files. The extracted images can thereafter be saved directly onto the hard drive or can be converted and incorporated into new documents.

## Extract Text Example

The extraction of text can be implemented for both existing PDFs and those that are freshly created. Through the use of the `ExtractAllText` method, one can obtain a string output encompassing all text found within a specified PDF, with page separations indicated by four consecutive `Environment.NewLines`. Here is a practical example using a [sample PDF](https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/sample.pdf) that originates from the Wikipedia website.

```cs
using System.IO;
using IronPdf;

namespace ironpdf.ExtractTextAndImages
{
    public class Section1
    {
        public void Run()
        {
            // Load the PDF document
            PdfDocument pdfDocument = PdfDocument.FromFile("sample.pdf");
            
            // Perform the text extraction
            string extractedText = pdfDocument.ExtractAllText();
            
            // Save the extracted text to a text file
            File.WriteAllText("outputText.txt", extractedText);
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text.webp" alt="Extracted text" class="img-responsive add-shadow">
    </div>
</div>

### Extract Text by Line and Character

It's feasible to extract text by its line and character details within individual PDF pages. Begin by selecting a page and utilize the **Lines** and **Characters** properties to explore the text, including their specific page coordinates denoted as Top, Right, Bottom, and Left values.

```cs
using System.Linq;
using IronPdf;

namespace ironpdf.ExtractTextAndImages
{
    public class Section2
    {
        public void Run()
        {
            // Access the PDF document
            PdfDocument pdfDocument = PdfDocument.FromFile("sample.pdf");
            
            // Retrieve lines and individual characters from page one
            var pageLines = pdfDocument.Pages[0].Lines;
            var pageCharacters = pdfDocument.Pages[0].Characters;
            
            // Save the line data with positioning to a file
            File.WriteAllLines("extractedLines.txt", pageLines.Select(line => $"at Y={line.BoundingBox.Bottom:F2}: {line.Contents}"));
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-text-by-line-character.webp" alt="Extracted text by line and character" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Extract Images Example

To obtain all embedded images from the PDF, utilize the `ExtractAllImages` method, which provides a collection of images as `AnyBitmap` objects. Below, we illustrate using the previously referenced document to extract images and save them to a designated folder.

```cs
using IronPdf;

namespace ironpdf.ExtractTextAndImages
{
    public class Section3
    {
        public void Run()
        {
            // Open the PDF file
            PdfDocument document = PdfDocument.FromFile("sample.pdf");
            
            // Extract images embedded within
            var embeddedImages = document.ExtractAllImages();
            
            // Iterate through images and save each to disk
            for(int index = 0; index < embeddedImages.Count; index++)
            {
                embeddedImages[index].SaveAs($"images/image{index}.png");
            }
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/extract-text-and-images/extract-images.webp" alt="Extracted images" class="img-responsive add-shadow">
    </div>
</div>

In addition to using `ExtractAllImages`, one may also employ `ExtractAllBitmaps` or `ExtractAllRawImages` for more specialized needs. The former returns images as `AnyBitmap` objects, while the latter extracts raw image data as byte arrays (`byte[]`).

<hr>

## Extract Text and Images on Specific Pages

You can also opt to perform text and image extractions on chosen pages of a PDF. Employ the `ExtractTextFromPage` and `ExtractTextFromPages` methods for text, and `ExtractImagesFromPage` and `ExtractImagesFromPages` for images.

```cs
using IronPdf;

namespace ironpdf.ExtractTextAndImages
{
    public class Section4
    {
        public void Run()
        {
            // Load the PDF
            PdfDocument document = PdfDocument.FromFile("sample.pdf");
            
            // Extract text from the first page
            string singlePageText = document.ExtractTextFromPage(0);
            
            // Define page array for multiple extractions
            int[] specifiedPages = new[] { 0, 2 };
            
            // Extract text from specified pages
            string textFromMultiplePages = document.ExtractTextFromPages(specifiedPages);
        }
    }
}
```
This comprehensive guide provides all the necessary instructions and examples to successfully extract text and images from PDFs using IronPdf, effectively making it easy to manipulate and repurpose PDF content as per your needs.