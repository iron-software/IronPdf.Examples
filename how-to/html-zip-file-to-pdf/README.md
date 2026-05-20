# Rendering HTML Zip Files to PDF

***Based on <https://ironpdf.com/how-to/html-zip-file-to-pdf/>***


While working on projects, using ZIP packages can help save space and facilitate easier file transfers. For users who need to render HTML files stored inside a ZIP archive, the manual extraction is not necessary. IronPDF provides the functionality to directly render a complete project, including all assets, from a ZIP file. In this guide, we'll show you how to effortlessly transform an HTML ZIP package into a PDF document.

## Quickstart: HTML ZIP to PDF Conversion Using IronPDF

You can easily convert HTML files within a ZIP package to a PDF file using IronPDF. This quick guide will show you how to utilize the `RenderZipFileAsPdf` method from the IronPDF library to instantly convert your zipped HTML files into sleek PDF documents. This method is ideal for developers looking to enhance their productivity by incorporating PDF generation directly into their C# projects without the hassle of manual file extraction.

```cs
// Title: One-step HTML ZIP to PDF conversion!
new IronPdf.ChromePdfRenderer().RenderZipFileAsPdf("htmlSample.zip", "htmlSample.html").SaveAs("output.pdf");
```

---

## Tutorial: Converting an HTML ZIP File to PDF

This section outlines how to use the `RenderZipFileAsPdf` method to convert an HTML file within a ZIP package to a PDF document. You only need to specify the ZIP file path and the HTML file name inside the ZIP.

After conversion, the PDF document is saved as `output.pdf`.

### HTML Source File

Here is the `htmlSample.html` which will be rendered into a PDF:

```html
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Sample HTML with External CSS and JS</title>
  
  <link rel="stylesheet" href="style.css">
</head>
<body>
  <div class="container">
    <h1>Welcome to the Sample Page!</h1>
    <p id="greeting">Click the button to change the background color and greeting text.</p>
    <button id="changeButton">Change Background</button>
  </div>

  <script src="script.js"></script>
</body>
</html>
```

View this HTML page rendered in a Chromium browser below.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-zip-file-to-pdf/htmlSample.html" width="100%" height="150px">
</iframe>

### Implementation in Code

```cs
// Set up the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render the ZIP file to PDF and retrieve the document
PdfDocument pdf = renderer.RenderZipFileAsPdf("htmlSample.zip", @"htmlSample.html");

// Save the rendered PDF
pdf.SaveAs("output.pdf");
```

### Final Output

Below is the resulting PDF from the previous code implementation.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-zip-file-to-pdf/output.pdf" width="100%" height="500px">
</iframe>

By following these steps, you can efficiently convert any HTML stored inside a ZIP file directly into a high-quality PDF document using IronPDF.