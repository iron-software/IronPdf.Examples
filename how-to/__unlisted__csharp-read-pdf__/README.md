# C# Read PDF Guide

***Based on <https://ironpdf.com/how-to/__unlisted__csharp-read-pdf__/>***


In this session, we'll explore a straightforward approach to reading PDF files and extracting texts while preserving their format. This technique can be applied to both entire documents or specific pages within your C# application.

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

<h3>Begin with IronPDF</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

--------------------------------------

## Extracting PDF Content in C&num;

Utilize the capabilities of this C# library to open and read PDF files, pull out texts, and even retrieve high-resolution, original images. Below are some examples showcasing different methods to fulfill your PDF extraction requirements in a .NET framework.

```csharp
using IronPdf;
using IronSoftware.Drawing;
using System.Collections.Generic;

// Load your PDF file here
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve all text from the PDF
string allText = pdf.ExtractAllText();

// Fetch all Images
IEnumerable<AnyBitmap> AllImages = pdf.ExtractAllImages();

// Alternatively, use PageCount to combine the above functionalities
for (var index = 0; index < pdf.PageCount; index++)
{
    string Text = pdf.ExtractTextFromPage(index);
    IEnumerable<AnyBitmap> Images = pdf.ExtractImagesFromPage(index);
}
```

### Presentation of Results

Using a simple C# Form, we demonstrate the effortless output obtained from reading the PDF content. This method emphasizes simplicity and minimal coding to meet the needs of your projects.

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
<h4 class="tutorial-segment-title">Quick Library Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Access Library Documentation</h3>
      <p>Explore and utilize the comprehensive API Reference Documentation for the IronPDF library.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank">IronPDF API Reference Documentation <i class="fa fa-chevron-right"></i></a>
    </div>
  </div>
</div>