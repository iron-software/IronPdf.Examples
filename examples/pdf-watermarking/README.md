***Based on <https://ironpdf.com/examples/pdf-watermarking/>***

IronPDF offers functionalities to add 'watermarks' to PDF documents using HTML.

The `ApplyStamp` method allows developers to insert HTML-based watermarks into a PDF. Within the example shown, the HTML markup for the watermark is passed as the initial argument of the method. Additional parameters passed to `ApplyStamp` help fine-tune the rotation, transparency, and positioning of the watermark.

Opt for `ApplyStamp` instead of `ApplyWatermark` when you need precise control over the watermark attributes. Here are some capabilities of the `ApplyStamp` method:

- Insert Text, Image, or HTML watermarks into PDF documents
- Consistently overlay the same watermark across all pages of the PDF
- Assign different watermarks to select pages within a document
- Configure whether watermarks appear above or below the main content
- Finely adjust watermark transparency, rotation, and alignment

---

### Sample C# Code to Insert a Watermark Using IronPDF

First, ensure the IronPDF library is integrated into your project. You can refer to the instructions on the [IronPDF NuGet package page](https://nuget.org/packages/IronPdf/).

**Code Breakdown:**

- Begin by importing the `IronPdf` namespace, equipping you with necessary classes and methods for PDF edits.
- Either open an existing PDF or create a new one using `PdfDocument.FromFile`, pointing to the file path.
- Define the HTML content to be used as the watermark, such as "Confidential," which includes styling specifics.
- Employ the `ApplyStamp` method to apply the watermark onto the PDF. This method supports extensive customization:
  - `rotationDegrees`: Sets the watermark's rotation angle.
  - `left` and `top`: Control the watermark's X and Y positions, starting from the upper left corner.
  - `opacity`: Adjusts the watermark's transparency.
  - `pageRange`: Chooses the pages that will receive the watermark to allow varied application across the document.
- Lastly, the `SaveAs` method is called to export the revised PDF to a new location.

In summary, the IronPDF `ApplyStamp` technique provides detailed control over watermarking PDF documents with HTML. This method is versatile, supporting several customization options for placement, style, and specific page application.

[Learn more about Custom Watermarking with IronPDF](https://ironpdf.com/how-to/custom-watermark/)