# C# PDF Parser

> Full guide: [C# PDF Parser](https://ironpdf.com/how-to/csharp-parse-pdf/)


This guide walks through parsing PDF files from C# with IronPDF.

## Quickstart: Efficient PDF Parsing with IronPDF

This tutorial extracts the full text of a PDF while preserving its layout, using IronPDF's `ExtractAllText` method.

```cs
// Instantly Parse PDFs with IronPDF
var text = IronPdf.FromFile("sample.pdf").ExtractAllText();
```

## C# PDF File Parsing

The snippet below pulls the text out of an entire PDF with the `ExtractAllText` method. You will also notice a comparison below, illustrating the consistency between the original PDF content and the extracted text.

```cs
using IronPdf;

// Open your target PDF File
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract all text from the PDF
string allText = pdf.ExtractAllText();

// Extract text specifically from the first page
string page1Text = pdf.ExtractTextFromPage(0);
```

### Displaying the Parsed PDF Content

To demonstrate the output of the parsed PDF content, we utilize a C# Form. The displayed text is exactly as it appears in the PDF, making it perfect for personal or business document processing.

<div class="row">
<div class="col-md-6">
<center>
<h3>~ PDF ~</h3>
<div class="center-image-wrapper">
<a rel="nofollow" href="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf4.png" target="_blank">
<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf4.png" alt="" class="img-responsive add-shadow">
</a>
</div>
</center>
</div>
<div class="col-md-6">
<center>
<h3>~ C# Form ~</h3>
<div class="center-image-wrapper">
<a rel="nofollow" href="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf5.png" target="_blank">
<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf5.png" alt="" class="img-responsive add-shadow">
</a>
</div>
</center>
</div>
</div>

<hr class="separator">
<h4 class="tutorial-segment-title">Library Quick Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Documentation</h3>
      <p>Explore the comprehensive API Reference to learn more about IronPDF and its extensive features.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>

Ready to explore more? Visit our tutorial page here: [Edit PDFs](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/)