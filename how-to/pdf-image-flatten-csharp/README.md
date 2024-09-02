# Flatten PDFs with C#

Flattening PDF files involves converting interactive elements like text fields, checkboxes, radio buttons, and dropdown lists into static images, ensuring the document's contents can no longer be modified. IronPDF simplifies this process in C#, allowing you to make PDFs non-editable with a straightforward coding approach.

<center>
	<div style="display: flex; align-items: center; justify-content: center;">
		<div class="center-image-wrapper" style="max-width: 200px;">
			<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp.jpg" alt="" class="img-responsive add-shadow">
		</div>
		<div class="center-image-wrapper" style="max-width: 100px;">
			<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp2.png" alt="" class="img-responsive add-shadow">
		</div>
		<div class="center-image-wrapper" style="max-width: 100px">
			<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp3.png" alt="" class="img-responsive add-shadow">
		</div>
	</div>
</center>

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Steps to Flatten a PDF in C#</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-the-ironpdf-software">Install IronPDF software</a></li>
        <li><a href="#anchor-2-flatten-c-num-pdf-document">Flatten a PDF file in C#</a></li>
        <li><a href="#anchor-3-check-the-flattened-document">Create an unfillable document</a></li>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="https://ironpdf.com/csharp-pdf.pdf" target="_blank">
          <img style="box-shadow: none; width: 308px; height: 320px;" src="https://ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" class="img-responsive learn-how-to-img">
        </a>
      </div>
    </div>
  </div>
</div>

<hr class="separator">

## Code Example: Flatten C# PDF Document

After successfully installing IronPDF, flattening your PDF document is a cinch. First, instantiate a `PdfDocument` object to handle the PDF. You can also generate a PDF from scratch if needed by utilizing the `ChromePdfRenderer`.

Below, we demonstrate how to flatten a PDF, making it unmodifiable and removing all interactive elements like radio buttons and checkboxes using a simple `Flatten` method demonstration.

```cs
using IronPdf;

// Open the desired PDF File
PdfDocument pdf = PdfDocument.FromFile("before.pdf");

// Execute the Flatten method
pdf.Flatten();

// Save the flattened PDF under a new name
pdf.SaveAs("after_flatten.pdf");
```

### Verify the Flattened Document

Below, compare the first editable PDF—our original file—to our newly flattened version, achieved with the above IronPDF functionality. This approach is applicable for diverse .NET PDF projects.

<center>
	<div class="center-image-wrapper">
		<a rel="nofollow" href="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" target="_blank">
			<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" alt="" class="img-responsive add-shadow">
		</a>
	</div>
</center>

After flattening, the forms and interactive widgets will no longer be operational.

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
      <h3>Explore More on PDFs</h3>
      <p>Dive deeper into the documentation to discover more about PDF flattening, editing, manipulation, and beyond.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Explore More Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>