IronPDF offers various methods to embed watermarks within PDF documents utilizing HTML content.

The `ApplyStamp` function allows developers to insert an HTML-based watermark into a PDF document. In the given example, the HTML string to be used as a watermark is passed as the first parameter to the function. Additional parameters in `ApplyStamp` include settings for rotation, opacity, and watermark positioning.

Opt for the `ApplyStamp` function over `ApplyWatermark` for enhanced control over the watermark's placement. Utilizing `ApplyStamp` can facilitate:

- Embedding text, image, or HTML watermarks into PDFs
- Consistently applying the same watermark across all pages of a PDF
- Adding unique watermarks to select pages within a PDF
- Positioning watermarks either in front of or behind the existing text on the page
- Fine-tuning the opacity, rotation, and alignment of watermarks with greater accuracy

___