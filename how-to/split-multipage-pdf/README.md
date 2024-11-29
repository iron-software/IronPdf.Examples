# Split a Multi-Page Document into a Single PDF

***Based on <https://ironpdf.com/how-to/split-multipage-pdf/>***


Converting a multi-page PDF document into separate single-page PDFs is a straightforward process. The example below demonstrates how to accomplish this in just a few lines of code using IronPDF.

IronPDF simplifies the task of dividing a single PDF document into multiple documents, with each one containing a single page.

<div class="learn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Split a PDF Document</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-ironpdf-to-your-c-project">Install the IronPDF library</a></li>
        <li><a href="#anchor-2-split-a-multipage-pdf">Split a multiple-page PDF into individual documents</a></li>
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

## Split a Multipage PDF

Once IronPDF is set up in your project, you can easily separate a multipage PDF into individual single-page PDF files. This is primarily achieved by extracting pages using the `CopyPage` or `CopyPages` methods.

```cs
using IronPdf;
namespace ironpdf.SplitMultipagePdf
{
    public class Section1
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("multiPage.pdf");
            
            for (int idx = 0; idx < pdf.PageCount; idx++)
            {
                // Generate a new document for each individual page
                PdfDocument singlePageDocument = pdf.CopyPage(idx);
            
                string newFileName = $"SinglePage-{idx + 1}.pdf";
            
                // Save the single page document
                singlePageDocument.SaveAs(newFileName);
            }
        }
    }
}
```

In the code snippet above, a loop iterates through each page of the existing PDF. The `CopyPage` method is then used to create a new `PdfDocument` instance for every page, which is subsequently saved as a new file, thereby effectively splitting the PDF into separate single-page documents.