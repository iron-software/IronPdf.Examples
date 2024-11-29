# Adding a PDF Cover Page Using IronPDF in C#

***Based on <https://ironpdf.com/how-to/edit-add-cover-page-csharp/>***


Integrating a cover page into PDFs is a common requirement in software development projects that deal with document management. IronPDF simplifies this task, allowing .NET developers to add a cover page to a PDF with minimal effort. Below is a guide to show you how to achieve this.

<center>
<h3>Cover Page Example</h3>
<div style="display: flex; align-items: center; justify-content: center;">
<div class="center-image-wrapper" style="max-width: 150px; margin-right: 20px;">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp.jpg" alt="Cover Page Example 1" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper" style="max-width: 100px">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp2.png" alt="Cover Page Example 2" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper" style="max-width: 150px; margin-left: 10px;">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp3.png" alt="Cover Page Example 3" class="img-responsive add-shadow">
</div>
</div>
</center>

<div class="learn-how-section">
<div class="row">
<div class="col-sm-6">
<h2>Steps for Adding a PDF Cover Page</h2>
<ul class="list-unstyled">
<li><a href="#anchor-1-install-c-library-to-visual-studio">Install IronPDF Library to Visual Studio</a></li>
<li><a href="#anchor-2-add-c-pdf-cover-page">Integrate a cover page into your PDF</a></li>
<li><a href="#anchor-3-merge-pdfs-for-result">Merge documents to produce the final PDF</a></li>
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

## Implementing a Cover Page in C# Using IronPDF

Adding a cover page to PDFs is straightforward with the use of IronPDF. With just a couple of lines of code, you can streamline your document's appearance whether you're handling a single document or merging multiple PDFs.

Below, we provide an example where a PDF serves as a cover page and another PDF contains the main content. We combine them into one document using IronPDF's capabilities. You can find the implementation in the code demonstration provided.

```cs
using IronPdf;
namespace ironpdf.EditAddCoverPageCsharp
{
    public class Section1
    {
        public void Run()
        {
            // Create a new instance of the Chrome Pdf Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Generate a PDF from HTML for the cover page
            PdfDocument coverPdf = renderer.RenderHtmlAsPdf("<h1>Welcome to Our Report</h1>");
            
            // Create a PDF from a URL for main content
            PdfDocument onlinePdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
            
            // Merge the PDFs and output to file
            PdfDocument.Merge(coverPdf, onlinePdf).SaveAs("final-report.pdf");
        }
    }
}
```

### Combining PDFs into a Single Document

As demonstrated below, two distinct PDF files, one serving as the cover and the other containing the primary content, are seamlessly merged into a unified document using IronPDF's `Merge` method.

<div class="row">
<div class="col-md-6">
<center>
<h3>First PDF Example</h3>
<div class="center-image-wrapper">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp4.png" alt="First PDF" class="img-responsive add-shadow">
</div>
</center>
</div>
<div class="col-md-6">
<center>
<h3>Second PDF Example</h3>
<div class="center-image-wrapper">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp5.png" alt="Second PDF" class="img-responsive add-shadow">
</div>
</center>
</div>
</div>

<center>
<h3>Combined PDF Example</h3>
<div class="center-image-wrapper" style="max-width: 130px;">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp6.png" alt="Merged PDF" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper">
<img src="https://ironpdf.com/img/faq/edit-add-cover-page-csharp/edit-add-cover-page-csharp7.png" alt="Merged PDF Example" class="img-responsive add-shadow">
</div>
</center>

<hr class="separator">
<h4 class="tutorial-segment-title">Quick Access to Library Resources</h4>

<div class="tutorial-section">
<div class="row">
<div class="col-sm-4">
<div class="tutorial-image">
<img style="max-width: 110px; width: 100px; height: 140px;" alt="API Icon" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
</div>
</div>
<div class="col-sm-8">
<h3>Explore Our Documentation</h3>
<p>Refer to the comprehensive API documentation for more details on implementing IronPDF features.</p>
<a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank">Access the IronPDF API Reference<i class="fa fa-chevron-right"></i></a>
</div>
</div>
</div>