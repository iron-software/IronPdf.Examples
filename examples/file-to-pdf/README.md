***Based on <https://ironpdf.com/examples/file-to-pdf/>***

IronPDF is a robust .NET library designed for converting HTML content into high-quality PDF documents. Utilizing IronPDF enables developers to transform HTML into PDF effortlessly, maintaining adherence to the latest web standards and ensuring that the PDF output is a precise replica of the original HTML. The process is streamlined by the `ChromePdfRenderer` class, which efficiently manages the conversion from HTML to PDF.


<div class="examples__featured-snippet">
    <h2>Guide on Converting HTML to PDF Using IronPDF</h2>
    <ol>
        <li>Add the C# IronPDF library to your project for HTML to PDF conversion.</li>
        <li><code>using IronPdf;</code></li>
        <li><code>var renderer = new ChromePdfRenderer();</code></li>
        <li><code>var pdf = renderer.RenderHtmlFileAsPdf("example.html");</code></li>
        <li><code>pdf.SaveAs("output.pdf");</code></li>
    </ol>
</div>
```

The above code snippet demonstrates how to generate a new PDF document by rendering an HTML file. First, ensure the IronPDF library is installed and added in your project using `using IronPdf`. Then, create an instance of the `ChromePdfRenderer` class. This class is adept at converting HTML content into PDF without losing the original layout and quality.

After initializing the `ChromePdfRenderer`, use the `RenderHtmlFileAsPdf` method to transform a specified HTML file into a PDF document. In the provided example, the HTML file "example.html" is converted into a `pdf` object. Lastly, the `SaveAs` method is used to store the produced PDF under the name "output.pdf". This straightforward procedure facilitates the creation of PDF documents from HTML content in C# applications.

[Learn to Convert HTML Files to PDF with IronPDF](https://ironpdf.com/how-to/html-file-to-pdf/)