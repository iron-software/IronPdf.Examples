***Based on <https://ironpdf.com/examples/pdf-compression/>***

IronPDF provides functionality to compress PDF documents. A predominant method of decreasing PDF file sizes involves minimizing the size of embedded images in the document by utilizing the `CompressImages` method.

When it comes to resizing JPEGs, maintaining 100% quality results in minimal loss, whereas 1% quality yields images of significantly lower quality. Typically, qualities between 90% to 100% are regarded as high-quality, 80% to 90% as medium-quality, and 70% to 80% as lower-quality. Setting the quality below 70% can substantially reduce the PDF file size, though it may compromise the image quality severely.

It's recommended to try varying the quality levels to understand the trade-off between image quality and file size better. This balance will be critical and varies based on the nature of your project and specific needs. The extent of quality degradation will depend on the original image used; some might deteriorate more noticeably than others.