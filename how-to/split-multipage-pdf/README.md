# Extract Individual Pages from a Multi-Page PDF

Extracting each page from a multi-page PDF into separate documents can be quickly achieved using just a few lines of code. Below is a guideline to help you integrate this functionality into your applications.

Using IronPDF, you can effortlessly divide a single PDF file into multiple PDFs, with each output PDF containing only one page.

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>PDF Document Segmentation</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-ironpdf-to-your-c-project">Install the IronPDF library</a></li>
        <li><a href="#anchor-2-split-a-multipage-pdf">Segment a multipage PDF into individual documents</a></li>
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

After installing IronPDF, you're ready to split a multipage PDF into numerous single-page PDFs. The process involves duplicating either a single or multiple pages using the `CopyPage` or `CopyPages` methods.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multiPage.pdf");

for (int i = 0; i < pdf.PageCount; i++)
{
    // Generate a new document for each page
    PdfDocument individualPage = pdf.CopyPage(i);

    string newFileName = @$"multiPage - Page {i + 1}_tempfile.pdf";

    // Save the new page to a file
    individualPage.SaveAs(newFileName);
}
```

The snippet shown demonstrates how to use a for loop to cycle through each page of the PDF. It then employs the `CopyPage` method to create a separate **PdfDocument** instance for each page, which is subsequently saved as a new file.