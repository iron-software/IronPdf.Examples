Leverage IronPDF to transform a PDF into images based on your preferred file format, dimensions, and DPI settings.

For transforming a PDF into images, utilize the `RasterizeToImageFiles` method on a `PdfDocument` instance. A PDF can be initialized using the `PdfDocument.FromFile` method or through one of the various [PDF creation techniques](https://ironpdf.com/tutorials/dotnet-core-pdf-generating/).

---

`RasterizeToImageFiles` processes each page of the PDF document, turning it into a raster image. The primary argument controls the naming format for each resulting image. You can further tailor the output by specifying additional parameters that adjust the image's quality and dimensions. Additionally, an argument allows for the conversion of selected pages of the PDF into images.

For quick PDF to bitmap conversion, refer to the `ToBitMap` method showcased on line 24 of the sample code. This method can be applied to any `PdfDocument` object, facilitating the swift transformation of PDFs into `AnyBitmap` objects. These bitmaps can then be either stored as files or further modified as required.

---