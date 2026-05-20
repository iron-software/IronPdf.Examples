# Split a Multi-Page Document into Individual PDFs

***Based on <https://ironpdf.com/how-to/split-multipage-pdf/>***


Dividing a multi-page PDF document into distinct PDF files, where each file contains just one page, is a task that can be easily achieved with a minimal amount of coding. Explore our example for integrating this functionality into your application.

IronPdf offers four different types of stampers—`TextStamper`, `ImageStamper`, `HTMLStamper`, and `BarcodeStamper`. The `HTMLStamper` is exceptionally versatile, allowing for the use of complete HTML capabilities and CSS styles.

## Quickstart: Transform Multi-Page PDF into Single Pages

Begin swiftly with IronPDF to segregate a multi-page PDF into individual page documents. Leveraging the `CopyPage` method allows for a clean and efficient walk-through of each page in the document, saving them as separate files. This process is ideal for developers who need a quick, straightforward method to handle PDF documents.

```cs
:title=Simple PDF Splitting Example
var pdfDocument = new IronPdf.PdfDocument("multipage.pdf");
for (int page = 0; page < pdfDocument.PageCount; page++) {
  var singlePageDocument = pdfDocument.CopyPage(page);
  singlePageDocument.SaveAs($"single_page_{page + 1}.pdf");
}
```

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Steps to Split PDF Documents</h2>
      <ul class="list-unstyled">
        <li>Download and install the IronPDF library</li>
        <li>Separate a multi-page PDF into individual page documents</li>
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

## Efficiently Manage a Multipage PDF

With IronPDF at your disposal, you have the ability to dissect a multipage document into separate single-page files. The mechanics of dividing a multipage PDF involve the use of either the `CopyPage` or `CopyPages` methods for replicating sections of the PDF.

```csharp
using IronPdf;

PdfDocument multipagePdf = PdfDocument.FromFile("multiPage.pdf");

for (int pageIndex = 0; pageIndex < multipagePdf.PageCount; pageIndex++)
{
    // Generate new document for each page
    PdfDocument individualPdf = multipagePdf.CopyPage(pageIndex);

    string outputFile = @$"multiPage_Separated_Page_{pageIndex + 1}.pdf";

    // Save it as a new file
    individualPdf.SaveAs(outputFile);
}
```

The code depicted outlines the use of a loop to navigate through the pages of the original PDF document. It demonstrates how each page is replicated into a new **PdfDocument** and then saved independently with a sequentially assigned filename.

Interested in learning more? Discover additional techniques on our tutorial page here: [Master Your PDFs](https://ironpdf.com/tutorials/organize-pdfs-complete-tutorial/)