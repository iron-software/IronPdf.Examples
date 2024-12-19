# Flatten PDFs in C#

***Based on <https://ironpdf.com/how-to/pdf-image-flatten-csharp/>***


PDF documents frequently come with interactive elements like text boxes, checkboxes, radio buttons, and drop-down lists. To render these forms non-editable for various uses, it's necessary to flatten the PDF. With IronPDF, you can achieve this with one simple line of code in your C# applications.

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

<h3>Get started with IronPDF</h3>

----
<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>How to Flatten a C# PDF</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-the-ironpdf-software">Install the IronPDF software</a></li>
        <li><a href="#anchor-2-flatten-c-num-pdf-document">Flatten a C# PDF document</a></li>
        <li><a href="#anchor-3-check-the-flattened-document">Verify the non-editable document</a></li>
      </ul>
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

## Flatten C# PDF Document

After installing the IronPDF library, you are a line of code away from flattening any PDF document.

Use the `PdfDocument` class to open your PDF file. Additionally, if you need to create a PDF, consider using the `ChromePdfRenderer` class.

The `Flatten` method allows you to transform your PDF into a non-editable file by removing interactive elements such as checkboxes and radio buttons. The following sample demonstrates this in a C# application.

```cs
using IronPdf;

// Load your PDF
PdfDocument pdf = PdfDocument.FromFile("before.pdf");

// Apply the Flatten operation
pdf.Flatten();

// Save the flattened PDF
pdf.SaveAs("flattened.pdf");
```

### Check the Flattened Document

Below is the comparison between the originals, which are editable, and their flattened counterparts produced using IronPDF. This technique is useful across various .NET projects.

<center>
	<div class="center-image-wrapper">
		<a rel="nofollow" href="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" target="_blank">
			<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" alt="" class="img-responsive add-shadow">
		</a>
	</div>
</center>

The `Flatten` method will make forms undetectable.

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
      <h3>Read More Documentation</h3>
      <p>Explore the Documentation to learn more about PDF flattening, editing, manipulation, and other features.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Visit IronPDF Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>