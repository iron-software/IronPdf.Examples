***Based on <https://ironpdf.com/examples/pdf-compression/>***

IronPDF offers functionality to minimize the size of PDF files, mainly by compressing the images embedded within the document. This can be achieved using the `CompressImages` method.

In terms of resizing JPEG images, maintaining 100% quality ensures there is negligible loss, whereas setting the quality to 1% results in a significantly degraded image. In general, settings above 90% are considered to provide high quality, between 80% and 90% offer medium quality, and between 70% and 80% are seen as low quality. Dropping the quality below 70% can greatly diminish the clarity of the images but may considerably reduce the overall size of the PDF document.

It is recommended to test various compression settings to discover the ideal compromise between image quality and file size that meets your specific needs. The extent to which the quality reduction is noticeable will depend on the original image used, with some images degrading more noticeably than others.