***Based on <https://ironpdf.com/examples/pdf-compression/>***

IronPDF supports PDF compression primarily by reducing the size of the embedded images within the document via the `CompressImages` method.

Adjusting the quality setting for JPEGs is crucial as it affects the balance between file size and image clarity. A quality setting of 100% usually preserves most of the image’s original clarity, whereas a setting as low as 1% significantly reduces it. Typically, a setting between 90%-100% maintains high quality, 80%-90% is deemed medium quality, and 70%-80% falls into low quality. Dropping the image quality below 70% drastically decreases the file size but at the cost of noticeable image degradation.

It is advisable to test various quality settings to discover the optimal compromise between file size and clarity for your needs, especially since different images will react differently to compression.

## 5 Steps to Compress PDF Files in C#

Begin by loading the PDF you want to compress using the `PdfDocument` class. This class opens an existing PDF from a specified path.

Next, let's illustrate the process of compressing images within a PDF at a chosen quality level. By employing the `CompressImages` method and setting the desired quality, all images in the PDF will be compressed to 60% of their original quality. The quality parameter accepts values from 1 (poorest quality, highest compression) to 100 (best quality, minimal compression), which helps in reducing the overall file size, but it's important to be prepared for a reduction in image clarity. After compressing the images, the modified PDF can be saved using the `SaveAs` method.

Another method for compressing images within a PDF involves using the `CompressImages` method with image scaling. By setting the `ShrinkImage` boolean to true, images are scaled down to their visible dimensions within the PDF, which might cause image distortion if the images are significantly larger than their display size on the PDF.

The compressed PDF can finally be saved at the intended location using the `SaveAs` method once again. This technique is beneficial when aiming to optimize PDFs for reduced file sizes for purposes like web or email distribution, ensuring a balance between quality and compression.

[Optimize your PDFs with our Compression Guide.](https://ironpdf.com/how-to/pdf-compression/)