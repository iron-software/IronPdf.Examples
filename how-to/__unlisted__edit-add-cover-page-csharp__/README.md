# Add PDF Cover Page in C#

***Based on <https://ironpdf.com/how-to/__unlisted__edit-add-cover-page-csharp__/>***


In the realm of C# PDF manipulation, occasionally the need arises to integrate a cover page into a document. This is efficiently achieved using the IronPDF library, which supports the addition of a cover page directly within the code, eliminating the need for external software and simplifying the process to just a couple of lines of code.

### Getting Started with IronPDF

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

--------------------------------------

<center>
<h3>Cover Page Examples</h3>
<div style="display: flex; align-items: center; justify-content: center;">
<div class="center-image-wrapper" style="max-width: 150px; margin-right: 20px;">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp.jpg" alt="Example of cover page" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper" style="max-width: 100px">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp2.png" alt="Alternative cover page" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper" style="max-width: 150px; margin-left: 10px;">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp3.png" alt="Additional cover page example" class="img-responsive add-shadow">
</div>
</div>
</center>

<div class="learnn-how-section">
<div class="row">
<div class="col-sm-6">
<h2>How to Add a Cover Page</h2>
<ul class="list-unstyled">
<li>Integrate the C# library into Visual Studio</li>
<li>Append a cover page to your PDF</li>
<li>Merge to produce the final PDF document</li>
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

## Embedding a Cover Page in C# PDFs

Creating an added cover page for a PDF in C# is straightforward with IronPDF. Whether merging two PDF files or appending an additional page, it can be done quickly using minimal code.

In the following code snippet, you’ll see how a custom cover page is created and then merged with a primary content PDF, transforming them into a unified document. The PDFs were prepared with NuGet being one example, and a crafted cover page using `ChromePdfRenderer`.

```cs
using IronPdf;

// Create a new instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate the cover page PDF
PdfDocument coverPdf = renderer.RenderHtmlAsPdf("<h1>Welcome to Your Document</h1>");

// Render a PDF from a URL
PdfDocument contentPdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");

// Combine cover and content PDFs, then save
PdfDocument.Combine(coverPdf, contentPdf).SaveAs("final-document.pdf");
```

### Viewing the Merge Results

As you will observe from the accompanying images, the individual PDFs serve as a cover and content respectively. The `Combine` method streamlines them into one document through a concise coding approach.

<div class="row">
<div class="col-md-6">
<center>
<h3>~ Cover PDF ~</h3>
<div class="center-image-wrapper">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp4.png" alt="Cover PDF" class="img-responsive add-shadow">
</div>
</center>
</div>
<div class="col-md-6">
<center>
<h3>~ Content PDF ~</h3>
<div class="center-image-wrapper">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp5.png" alt="Content PDF" class="img-responsive add-shadow">
</div>
</center>
</div>
</div>

<center>
<h3>~ Final Merged PDF ~</h3>
<div class="center-image-wrapper" style="max-width: 130px;">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp6.png" alt="Merged PDF Thumbnail" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp7.png" alt="Full Merged PDF View" class="img-responsive add-shadow">
</div>
</center>

<hr class="separator">
<h4 class="tutorial-segment-title">Quick Links to Library Resources</h4>

<div class="tutorial-section">
<div class="row">
<div class="col-sm-4">
<div class="tutorial-image">
<img style="max-width: 110px; width: 100px; height: 140px;" alt="Documentation Icon" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
</div>
</div>
<div class="col-sm-8">
<h3>Explore Further</h3>
<p>Extend your understanding by exploring the documentation provided in this and other tutorials by visiting the API Reference.</p>
<a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank">Discover More at IronPDF API Reference<i class="fa fa-chevron-right"></i></a>
</div>
</div>
</div>