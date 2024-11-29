***Based on <https://ironpdf.com/examples/pdf-watermarking/>***

IronPDF facilitates the addition of 'watermark' elements to PDF documents using HTML content.

By employing the `ApplyStamp` method, developers can incorporate HTML-based watermarks into a PDF file. The HTML markup intended for the watermark is provided as the initial argument to this method. Subsequent parameters to `ApplyStamp` allow modifications to the watermark's rotation, transparency, and placement within the document.

Opt for the `ApplyStamp` method rather than the `ApplyWatermark` method to achieve finer control over the positioning of watermarks. This method is particularly useful for several tasks:

- Embedding Text, Image, or HTML watermarks within PDFs
- Consistently applying the same watermark across all pages of the PDF document
- Implementing variant watermarks on specific pages of the PDF
- Modifying the watermark's visibility to either overlay or underlay the existing page content
- Fine-tuning the watermark's opacity, orientation, and alignment for precise placement

___