***Based on <https://ironpdf.com/examples/pdf-page-orientation/>***

When working with IronPDF to create or render PDFs, you have the option to configure the document orientation, which is critical for ensuring your content is displayed precisely as intended. The `PdfPaperOrientation` class is essential for setting the paper orientation when converting [HTML to PDF with IronPDF](https://ironpdf.com/tutorials/html-to-pdf/).

Here’s how to apply specific paper orientations to your documents:

IronPDF provides two key properties called `PaperOrientation` and `PageRotation`, each serving distinct purposes. Understanding when and how to use each can enhance your document handling capabilities.

### `PdfPaperOrientation` - For New PDF Documents Created from HTML or URLs:

- This parameter is applicable only when converting HTML content or URLs into PDFs.
- To set the document to Landscape orientation, utilize: `renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;`
- To set it to Portrait orientation, use: `renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Portrait;`
- Note that once the document is rendered, the orientation setting does not persist within the PDF file.

### `PageRotation` - For Modifying Existing PDF Documents:

- This parameter adjusts the rotation of pages within an existing PDF and is not applicable during the creation of new PDFs.
- It’s a property maintained within the PDF document and can be applied on a per-page basis.
- Newly created documents default to a `PageRotation` of `None`.
- Changing the `PageRotation` does not alter the physical dimensions of the page:
  - A rotation of `None` on a page sized `210mm x 297mm` will keep it at `width=210 height=297`
  - A rotation of `Clockwise90` on the same page dimensions does not change the width and height either.

Understanding these settings can streamline your PDF generation and modification processes, enabling more precise document layout management.