***Based on <https://ironpdf.com/examples/multi-frame-tiff-to-pdf/>***

IronPDF offers robust features for converting TIFF (Tagged Image File Format) files into high-quality PDF documents. This capability is utilized through the `ImageToPdfConverter.ImageToPdf` method. With its commitment to maintaining excellent quality, IronPDF ensures that the exported PDF document meticulously preserves the integrity of the original TIFF file.

## A Quick Two-Step Guide on Converting TIFF to PDF

Below, you'll find a straightforward code guide on how to transform a multi-page TIFF file into a PDF document:


### Detailed Steps

1. **Transform the TIFF File into PDF**: Initiate the process by supplying your TIFF file to the `ImageToPdfConverter.ImageToPdf` method. The `ImageToPdfConverter` class is specifically designed to facilitate the conversion of various image formats and Bitmap objects into PDFs. Utilizing just a few lines of code, this class efficiently manages the transformation of TIFF images into PDF, regardless of whether the output is a single-page or multi-page document.

2. **Preserve the PDF Document**: After converting the TIFF to PDF, the result is assigned to a `PdfDocument` object named **pdf**. The final step involves preserving this file. Employ the `SaveAs` method, and designate the desired file path to save your PDF.

[Learn more about the ImageToPdfConverter API](https://ironpdf.com/object-reference/api/IronPdf.ImageToPdfConverter.html) for additional insights.