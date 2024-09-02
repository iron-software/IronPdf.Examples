# Incorporate a PDF Cover Page Using C&num;

In C#, adding a cover page to a PDF file might sometimes be necessary, and using IronPDF presents a smooth and effective method to accomplish this. This straightforward approach doesn't require additional software and can be implemented with just a couple of lines of code. Below is a guide to achieving this.

<center>
	<h3>Cover Page</h3>
	<div style="display: flex; align-items: center; justify-content: center;">
		<div class="center-image-wrapper" style="max-width: 150px; margin-right: 20px;">
			<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp.jpg" alt="" class="img-responsive add-shadow">
		</div>
		<div class="center-image-wrapper" style="max-width: 100px">
			<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp2.png" alt="" class="img-responsive add-shadow">
		</div>
		<div class="center-image-wrapper" style="max-width: 150px; margin-left: 10px;">
			<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp3.png" alt="" class="img-responsive add-shadow">
		</div>
	</div>
</center>

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Merge and Add PDF Cover Page</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-c-library-to-visual-studio">Install C# Library to Visual Studio</a></li>
        <li><a href="#anchor-2-add-c-pdf-cover-page">Add a cover page to the PDF</a></li>
        <li><a href="#anchor-3-merge-pdfs-for-result">Merge for final PDF product</a></li>
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



## Add a Cover Page to Your C&num; PDF Document

Adding a cover page to your PDF document in C# using IronPDF is incredibly simple and requires only two lines of code, whether you are merging two PDF files or adding a page to a single one. The following example illustrates using one PDF for the cover and another for the main content. A cover page is generated using the **ChromePdfRenderer** class, and the `Merge` function is employed to amalgamate it with the main content PDF into a new file. Dive into the sample code below to see it in action within your project.

```cs
using IronPdf;

// Initialize the Chrome PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF for the cover page
PdfDocument coverPdf = renderer.RenderHtmlAsPdf("<h1>Welcome to Our Cover Page</h1>");

// Convert a URL to PDF
PdfDocument onlinePdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");

// Combine and save the PDFs.
PdfDocument.Merge(coverPdf, onlinePdf).SaveAs("final-combined.pdf");
```

### Combining PDFs for the Final Product

As illustrated below, two PDF files serve as your cover page and main content. By employing the `Merge` function, these two are seamlessly unified into a single document using minimal code.

<div class="row">
	<div class="col-md-6">
		<center>
			<h3>~ First PDF ~</h3>
			<div class="center-image-wrapper">
				<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp4.png" alt="" class="img-responsive add-shadow">
			</div>
		</center>
	</div>
	<div class="col-md-6">
		<center>
			<h3>~ Second PDF ~</h3>
			<div class="center-image-wrapper">
				<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp5.png" alt="" class="img-responsive add-shadow">
			</div>
		</center>
	</div>
</div>

<center>
	<h3>~ Combined Result ~</h3>
	<div class="center-image-wrapper" style="max-width: 130px;">
		<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp6.png" alt="" class="img-responsive add-shadow">
	</div>
	<div class="center-image-wrapper">
		<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp7.png" alt="" class="img-responsive add-shadow">
	</div>
</center>


<hr class="separator">
<h4 class="tutorial-segment-title">Quick Access to Library</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Share Documentation</h3>
      <p>Gain access to this tutorial's documentation and more by visiting our API Reference.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Share Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>