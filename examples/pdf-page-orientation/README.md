***Based on <https://ironpdf.com/examples/pdf-page-orientation/>***

When generating or visualizing your PDF using IronPDF, you can select from two layout orientations for your document. The `PdfPaperOrientation` class is key in setting the paper orientation while converting [HTML to PDF with IronPDF](https://ironpdf.com/tutorials/html-to-pdf/).

The following example demonstrates how to configure the paper orientation for your PDF documents.

IronPDF provides two distinct settings for PDFs known as `PaperOrientation` and `PageRotation`, each serving different purposes. It's essential to understand the appropriate context for using each setting.

`PdfPaperOrientation` - Applies to NEW PDF documents created from HTML or URL sources:

- This setting is applicable only when you are generating a document from HTML or a URL.
- To set the orientation to Landscape: `renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;`
- To set the orientation to Portrait: `renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Portrait;`
- Note that once the document is rendered, this orientation setting is no longer retained.

`PageRotation` - Pertains to existing PDF documents:

- This attribute can only be used with an existing document; it cannot be specified during the creation of a new document.
- This detail is preserved within the document itself and applies on a per-page basis.
- Pages in newly created documents will always default to a `PageRotation` of `None`.
- Changing the `PageRotation` does not alter the actual `width` and `height` of the page.
- For instance, applying a `PageRotation` of `None` to a `210mm x 297mm` size page will maintain the dimensions with `width=210 height=297`
- Likewise, setting a `PageRotation` of `Clockwise90` on a `210mm x 297mm` size page will keep the dimensions as `width=210 height=297`