***Based on <https://ironpdf.com/examples/pdf-page-orientation/>***

When working with IronPDF to create or modify PDF documents, users can set specific orientations for their documents. The `PdfPaperOrientation` class manages the paper orientation for converting [HTML to PDF with IronPDF](https://ironpdf.com/tutorials/html-to-pdf/).

Below is an illustration of how to specify the paper orientation for your PDF documents.

IronPDF offers two configuration options to adjust document layouts in PDFs: `PaperOrientation` and `PageRotation`. Each has its unique application contexts and should be used appropriately.

`PdfPaperOrientation` – This is applicable for NEW PDF documents converted from HTML or URLs:

- This setting is only relevant when converting content from HTML or URLs.
- Use Landscape orientation by configuring it here.
- Use Portrait orientation by setting it appropriately.
- Note: Once the PDF is rendered, this orientation setting is no longer retrievable.

`PageRotation` – This applies to pre-existing PDF documents:

- This property should only be used with already created PDF documents, meaning it cannot be set during the rendering of new documents.
- This setting is maintained on a per-page basis within the document’s metadata.
- Pages added to an existing document default to a `PageRotation` of `None`.
- The `PageRotation` setting does not alter the physical `width` and `height` of the page.
- For instance, setting a `PageRotation` of `None` for a page size of `210mm x 297mm` will maintain the dimensions as `width=210 height=297`.
- Similarly, setting a `PageRotation` of `Clockwise90` for the same page size does not change its dimensions.

[Learn more about page orientation and rotation in PDFs](https://ironpdf.com/how-to/page-orientation-rotation/) to better understand how to manipulate these properties for optimal document presentation.