# C# PDF Parser

Leveraging the right tools can simplify your experience with PDFs in C#, complementing your .NET applications with comprehensive PDF parsing capabilities. This guide will demonstrate how to efficiently accomplish this using IronPDF, a dedicated C# library, in a few simple steps.

<div style="display: flex; align-items: center; justify-content: center;">
	<div class="center-image-wrapper" style="max-width: 100px; margin-right: 20px;">
		<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf1.png" alt="" class="img-responsive add-shadow">
	</div>
	<div class="center-image-wrapper" style="max-width: 165px;">
		<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf2.png" alt="" class="img-responsive add-shadow">
	</div>
	<div class="center-image-wrapper" style="max-width: 100px; margin-left: 30px;">
		<img src="https://ironpdf.com/img/faq/csharp-parse-pdf/csharp-parse-pdf3.png" alt="" class="img-responsive add-shadow">
	</div>
</div>

## C# Parse PDF File

It's relatively straightforward to parse PDF files. In the following example, we utilize the `ExtractAllText` method to retrieve text from each line throughout the entire PDF document. Below, you can review the extracted PDF content side by side with the output.

```cs
using IronPdf;

// Load the desired PDF File
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text from the entire PDF
string allText = pdf.ExtractAllText();

// Extract text from the first page of the PDF
string page1Text = pdf.ExtractTextFromPage(0);
```

### View Parsed PDF Content

Below, using a C# Form, we display the parsed PDF content derived from the preceding code execution. This output accurately represents the text from a PDF, which you can utilize for either personal or business document requirements.

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
        <img style="max-width: 110px; width: 100px; height: 140px;" src="https://ironpdf.com/img/svgs/documentation.svg" alt="" class="img-responsive add-shadow" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Documentation</h3>
      <p>Explore the complete API Reference for IronPDF to fully understand its capabilities.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Documentation <i class="fa fa-chevron-right"></i></a>
    </div>
  </div>
</div>