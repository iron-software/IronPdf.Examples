# Divide a Multi-Page PDF into Individual PDFs

***Based on <https://ironpdf.com/how-to/split-multipage-pdf/>***


Dividing a multi-page PDF into individual pages is a process that can be accomplished with a few lines of code. Review our example below to see how to integrate this into your project.

IronPDF simplifies the process of segmenting a single PDF into multiple documents, where each document contains a single page.

### Begin with IronPDF

---

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Separate a PDF Document</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-ironpdf-to-your-c-project">Add the IronPDF library to your C# project</a></li>
        <li><a href="#anchor-2-split-a-multipage-pdf">Separate a PDF with multiple pages into individual documents</a></li>
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

## Segment a Multipage PDF

Upon installing IronPDF, you're set to break a multipage PDF into individual one-page files. Splitting such a document entails duplicating one or several pages utilizing the `CopyPage` or `CopyPages` method.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multiPage.pdf");

for (int idx = 0; idx < pdf.PageCount; idx++)
{
    // Generate a new document for each page
    PdfDocument singlePageDocument = pdf.CopyPage(idx);

    string fileName = $"multiPage - Page {idx + 1}_tempfile.pdf";

    // Save each page as a new file
    singlePageDocument.SaveAs(fileName);
}
```

This code snippet demonstrates how to use a for loop for traversing through the pages of an existing PDF, extracting each page into a new `PdfDocument` instance using the `CopyPage` method. Each extracted page is then saved as a separate file.