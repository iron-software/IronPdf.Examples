***Based on <https://ironpdf.com/examples/pdf-watermarking/>***

IronPDF provides capabilities for adding 'watermarks' to PDF documents using HTML.

Through the `ApplyStamp` method, developers have the ability to embed an HTML-based watermark into a PDF document. As illustrated, the HTML snippet intended for the watermark is passed as the primary parameter to the `ApplyStamp` method. Subsequent parameters allow for the adjustment of the watermark’s rotation, opacity, and placement within the document.

Opt for the `ApplyStamp` method over the `ApplyWatermark` method for enhanced control of watermark positioning. Specifically, the `ApplyStamp` method enables you to:

- Introduce Text, Image, or HTML watermarks into PDF files
- Consistently add the same watermark across all pages of the PDF
- Insert distinct watermarks to selected pages of the PDF
- Manipulate the placement of watermarks to appear either in front of or behind the text on the page
- Precisely modify watermark features such as opacity, rotation, and alignment

___