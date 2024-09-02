# C# PDF Reading Guide

In today's guide, we will explore an effective technique for reading PDF documents and extracting text while preserving its original layout. This functionality can be applied to entire PDF files or selected pages, neatly integrated into any C# project.

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

## Working with PDFs in C#

Leverage our C# library to open and read PDF files, extracting text and images with high fidelity. Below, we demonstrate various ways to utilize our library's capabilities to meet the needs of .NET applications.

```cs
using IronPdf;
using IronSoftware.Drawing;
using System.Collections.Generic;

// Load the PDF you want to process
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text from the whole document
string allText = pdf.ExtractAllText();

// Retrieve all images from the document
IEnumerable<AnyBitmap> allImages = pdf.ExtractAllImages();

// Additionally, extract text and images by each separate page using PageCount
for (var index = 0; index < pdf.PageCount; index++)
{
    string pageText = pdf.ExtractTextFromPage(index);
    IEnumerable<AnyBitmap> pageImages = pdf.ExtractImagesFromPage(index);
}
```

### Sample Output

Utilizing a C# Windows Forms interface, we can beautifully render the extracted PDF content, demonstrating a simple yet efficient code approach to fulfill the requirements of your project.

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
        <img style="max-width: 110px; width: 100px; height: 140px;" src="https://ironpdf.com/img/svgs/documentation.svg" alt="" class="img-responsive add-shadow" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Explore IronPDF Documentation</h3>
      <p>Access our detailed IronPDF library documentation available in the API Reference. It's your resource to explore and utilize for your projects.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Visit Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>