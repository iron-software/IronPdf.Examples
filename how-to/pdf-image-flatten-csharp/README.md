# Flatten PDFs in C&#35;

> Full guide: [Flatten PDFs in C&#35;](https://ironpdf.com/how-to/pdf-image-flatten-csharp/)


PDF documents can contain interactive elements like radio buttons, checkboxes, and text fields. When you need to make these documents non-editable for security or data integrity purposes, flattening the PDF becomes essential. IronPDF offers a straightforward method for flattening PDFs in C# using just a single line of code.

<center>
<div style="display: flex; align-items: center; justify-content: center;">
<div class="center-image-wrapper" style="max-width: 200px;">
<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp.jpg" alt="PDF before flattening" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper" style="max-width: 100px;">
<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp2.png" alt="Flattening process" class="img-responsive add-shadow">
</div>
<div class="center-image-wrapper" style="max-width: 100px">
<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp3.png" alt="PDF after flattening" class="img-responsive add-shadow">
</div>
</div>
</center>

## Quickstart: Flatten Your PDF in One Line

Utilize IronPDF to flatten PDF documents quickly and efficiently. This straightforward command in C# loads your PDF, flattens all interactive elements, and saves the result as a non-editable PDF. This method is perfect for .NET developers who need to ensure document security or simplicity.

```cs
IronPdf.PdfDocument.FromFile("input.pdf").Flatten().SaveAs("flattened_output.pdf");
```

## Flatten C# PDF Document

After integrating the IronPDF library into your project, flattening a PDF is as easy as executing a single line of code.

Below is a step-by-step guide on how to select and flatten a PDF using the `PdfDocument` class from IronPDF. You can generate a PDF using the `ChromePdfRenderer` class if your project demands it.

To remove interactive elements and secure the document, apply the `Flatten` method. Here’s how you can do it:

```csharp
using IronPdf;

// Define the PDF to be flattened
PdfDocument pdf = PdfDocument.FromFile("before.pdf");

// Apply the flatten process
pdf.Flatten();

// Output the flattened PDF
pdf.SaveAs("after_flattening.pdf");
```

### Verify the Flattened Document

Here’s the transformation: the first PDF retains its editable format, but after using the above code with IronPDF, the resulting document is flattened, making it non-editable. This technique is applicable across all your .NET PDF projects.

<center>
<div class="center-image-wrapper">
<a rel="nofollow" href="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" target="_blank">
<img src="https://ironpdf.com/img/faq/pdf-image-flatten-csharp/pdf-image-flatten-csharp4.png" alt="Flattened PDF" class="img-responsive add-shadow">
</a>
</div>
</center>

After flattening, forms and other interactive widgets will no longer be interactive.

<hr class="separator">
<h4 class="tutorial-segment-title">Library Quick Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="Documentation" class="img-responsive add-shadow" src="https://ironpdf.com/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Explore More Documentation</h3>
      <p>Dive into our Documentation to learn how to flatten, edit, and manipulate PDFs further.</p>
      <a class="doc-link" href="https://ironpdf.com/object-reference/api/IronPdf.html" target="_blank"> Visit IronPDF Documentation <i class="fa fa-chevron-right"></i></a>
      </div>
  </div>
</div>

Discover more capabilities by visiting our tutorial page: [Additional Features](https://ironpdf.com/tutorials/pdf-assets-and-performance-csharp/)