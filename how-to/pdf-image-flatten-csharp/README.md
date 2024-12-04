# Flatten PDFs in C#

***Based on <https://ironpdf.com/how-to/pdf-image-flatten-csharp/>***


Flattening a PDF is a useful technique for converting interactive elements such as text fields, checkboxes, radio buttons, and drop-down lists into static images. This prevents further modifications and is particularly beneficial for various application use-cases. Using IronPDF, you can perform PDF flattening in C# effortlessly with a mere single line of code.

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

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Steps to Flatten a PDF in C#</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-the-ironpdf-software">Install the IronPDF Library</a></li>
        <li><a href="#anchor-2-flatten-c-num-pdf-document">Execute the Flattening Process</a></li>
        <li><a href="#anchor-3-check-the-flattened-document">Verify the Flattened PDF</a></li>
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

With IronPDF installed, flattening your PDF documents becomes straightforward. 

In the following C# example, we employ the `PdfDocument` class to select our target PDF. For those requiring PDF generation, the `ChromePdfRenderer` class is available too.

Utilize the `Flatten` method to transform your PDF into a non-editable format. This action removes all interactive elements such as text fields and checkboxes. See the application of this process in the example below:

```cs
using IronPdf;
namespace ironpdf.PdfImageFlattenCsharp
{
    public class FlattenProcess
    {
        public void ExecuteFlatten()
        {
            // Load the target PDF file
            PdfDocument document = PdfDocument.FromFile("before_flatten.pdf");
            
            // Execute the flattening process on the PDF
            document.Flatten();
            
            // Store the changes in a new file
            document.SaveAs("flattened_result.pdf");
        }
    }
}
```

### Verify the Flattened PDF

Below is a comparison where the initial PDF is editable, while the processed file becomes non-editable thanks to the IronPDF library and the provided C# code. This functionality proves useful across various .NET PDF projects.

<center>
	<div class="center-image-wrapper">
		<a rel="nofollow" href="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" target="_blank">
			<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" alt="" class="img-responsive add-shadow">
		</a>
	</div>
</center>

After flattening, the forms within the document will become indistinguishable.

<hr class="separator">
<h4 class="tutorial-segment-title">Quick Library Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Explore More Documentation</h3>
      <p>Dive deeper into the documentation to learn additional techniques for manipulating PDFs and more.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank">Access IronPDF Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>