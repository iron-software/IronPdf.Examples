# C# Read PDF Guide

***Based on <https://ironpdf.com/how-to/csharp-read-pdf/>***


In this tutorial, we'll demonstrate an effortless technique for reading and extracting text from PDF files while maintaining the original format. This method can be applied to entire documents or individual pages within a C# application.

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

<h3>Introduction to IronPDF</h3>


--------------------------------------


## Reading PDF Files in C&num;

This C# library offers functionality to read, extract content, and retrieve high-quality images from PDF files. Below are examples illustrating various functions for satisfying your PDF reading requirements in a .NET framework.

```cs
using IronPdf;
using IronSoftware.Drawing;
using System.Collections.Generic;

// Load the PDF file
PdfDocument pdfDocument = PdfDocument.FromFile("example.pdf");

// Extract text from the entire PDF
string extractedText = pdfDocument.ExtractAllText();

// Retrieve all images from the PDF
IEnumerable<AnyBitmap> extractedImages = pdfDocument.ExtractAllImages();

// Alternatively, iterate through each page to extract text and images
for (int pageIndex = 0; pageIndex < pdfDocument.PageCount; pageIndex++)
{
    string pageText = pdfDocument.ExtractTextFromPage(pageIndex);
    IEnumerable<AnyBitmap> pageImages = pdfDocument.ExtractImagesFromPage(pageIndex);
}
```

### Results Display

We have designed a simple C# Form to visually display the extracted content from the PDF file. This method emphasizes efficiency and minimal coding to meet the needs of your projects.

<div class="row">
	<div class="col-md-6">
		<div class="content-img-align-center">
			<h3>~ PDF Visualization ~</h3>
			<div class="center-image-wrapper">
				<a rel="nofollow" href="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf4.png" target="_blank">
					<img src="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf4.png" alt="" class="img-responsive add-shadow">
				</a>
			</div>
		</div>
	</div>
	<div class="col-md-6">
		<div class="content-img-align-center">
			<h3>~ C# Form Display ~</h3>
			<div class="center-image-wrapper">
				<a rel="nofollow" href="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf5.png" target="_blank">
					<img src="https://ironpdf.com/img/faq/csharp-read-pdf/csharp-read-pdf5.png" alt="" class="img-responsive add-shadow">
				</a>
			</div>
		</div>
	</div>
</div>

<hr class="separator">
<h4 class="tutorial-segment-title">Quick Library Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Explore the Library Documentation</h3>
      <p>Take advantage of the comprehensive API Reference available for IronPDF to explore further and enhance your knowledge.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank">Access IronPDF API Reference Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>