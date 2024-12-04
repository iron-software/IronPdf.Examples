# C# Read PDF Tutorial

***Based on <https://ironpdf.com/how-to/csharp-read-pdf/>***


In this guide, we're going to explore a straightforward technique to read and extract text from PDFs while preserving the original formatting. This approach works for both complete documents and selected pages within a C# application.

<div style="display: flex; align-items: center; justify-content: center;">
	<div class="center-image-wrapper" style="max-width: 100px; margin-right: 20px;">
		<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf1.png" alt="" class="img-responsive add-shadow">
	</div>
	<div class="center-image-wrapper" style="max-width: 165px">
		<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf2.png" alt="" class="img-responsive add-shadow">
	</div>
	<div class="center-image-wrapper" style="max-width: 100px; margin-left: 30px;">
		<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf3.png" alt="" class="img-responsive add-shadow">
	</div>
</div>

## Extracting Content from PDF in C#

Leverage the power of this C# library to open, read, and extract both text and high-resolution images from PDF files. The following examples showcase several methods available to tailor PDF content extraction within a .NET framework:

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.CsharpReadPdf
{
    public class Section1
    {
        public void Run()
        {
            // Load the PDF file
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Retrieve all text from the PDF
            string allText = pdf.ExtractAllText();
            
            // Extract all images from the PDF
            IEnumerable<AnyBitmap> allImages = pdf.ExtractAllImages();
            
            // Iterate over each page and extract both text and images
            for (var index = 0; index < pdf.PageCount; index++)
            {
                string text = pdf.ExtractTextFromPage(index);
                IEnumerable<AnyBitmap> images = pdf.ExtractImagesFromPage(index);
            }
        }
    }
}
```

### Output Demonstration

We demonstrate the results using a C# Form, emphasizing the ease and minimal code required to fulfill your project requirements regarding PDF content extraction.

<div class="row">
	<div class="col-md-6">
		<div class="content-img-align-center">
			<h3>~ PDF ~</h3>
			<div class="center-image-wrapper">
				<a rel="nofollow" href="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf4.png" target="_blank">
					<img src="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf4.png" alt="" class="img-responsive add-shadow">
				</a>
			</div>
		</div>
	</div>
	<div class="col-md-6">
		<div class="content-img-align-center">
			<h3>~ C# Form ~</h3>
			<div class="center-image-wrapper">
				<a rel="nofollow" href="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf5.png" target="_blank">
					<img src="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf5.png" alt="" class="img-responsive add-shadow">
				</a>
			</div>
		</div>
	</div>
</div>

<hr class="separator">
<h4 class="tutorial-segment-title">Quick Access to Library Resources</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Library Documentation</h3>
      <p>Explore and utilize the comprehensive API Reference for IronPDF, designed to enhance your understanding and implementation of the library.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank">IronPDF API Reference Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>